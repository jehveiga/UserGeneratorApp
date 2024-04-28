using System.Net;
using System.Text.Json;
using UserGeneratorApp.Models;
using UserGeneratorApp.ViewModels;
using static UserGeneratorApp.Dtos.ResultUserDto;

namespace UserGeneratorApp.Services
{
    public class UserGeneratorService : IUserGeneratorService
    {
        private readonly HttpClient _httpClient;
        private ILogger<User> _logger;

        public UserGeneratorService(HttpClient httpClient, ILogger<User> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<UserViewModel> Get()
        {
            try
            {
                var response = await _httpClient.GetAsync("");

                if (response.IsSuccessStatusCode) // Status Code 200-299
                {
                    if (response.StatusCode == HttpStatusCode.NoContent) // Status 204
                        return default(UserViewModel);

                    // Retorna o valor serializado Json
                    string jsonString = await response.Content.ReadAsStringAsync();
                    // Deserialize JSON
                    Root myDeserializedClass = JsonSerializer.Deserialize<Root>(jsonString);
                    var userGeneratorResponse = myDeserializedClass.results[0];
                    var userViewModel = new UserViewModel(
                        $"{userGeneratorResponse.name.first} {userGeneratorResponse.name.last}",
                        userGeneratorResponse.email,
                        userGeneratorResponse.gender,
                        userGeneratorResponse.dob.date
                    );
                    return userViewModel;
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Status Code : {response.StatusCode} - {message}");
                }
            }
            catch (Exception)
            {

                _logger.LogError($"Erro a obter usuario");
                throw;
            }

        }
    }
}
