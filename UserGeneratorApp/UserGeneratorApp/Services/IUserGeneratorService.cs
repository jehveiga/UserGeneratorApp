using UserGeneratorApp.ViewModels;

namespace UserGeneratorApp.Services
{
    public interface IUserGeneratorService
    {
        Task<UserViewModel> Get();
    }
}
