using Microsoft.EntityFrameworkCore;
using UserGeneratorApp.Components;
using UserGeneratorApp.Data;
using UserGeneratorApp.Services;

namespace UserGeneratorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(option => option.UseNpgsql(connectionString));

            builder.Services.AddScoped<IUserGeneratorService, UserGeneratorService>();
            builder.Services.AddScoped<IUserService, UserService>();

            string baseUrl = "https://randomuser.me/api/";

            // Url base para serviço de acesso via HttpCliente, usando a injeção de dependencia do ASP .Net
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseUrl) });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.Run();
        }
    }
}
