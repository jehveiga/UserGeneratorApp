using UserGeneratorApp.Models;

namespace UserGeneratorApp.Services
{
    public interface IUserService
    {
        Task Add(User user);
        Task Delete(int id);
        Task Edit(User user);
        Task<IEnumerable<User>> GetAll();
        Task<User?> GetById(int id);
    }
}