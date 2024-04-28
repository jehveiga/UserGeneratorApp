using Microsoft.EntityFrameworkCore;
using UserGeneratorApp.Data;
using UserGeneratorApp.Models;

namespace UserGeneratorApp.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _dbContext;

        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            if (_dbContext is not null && _dbContext.Set<User>() is not null)
            {
                var usersDataBase = await _dbContext.Set<User>().ToListAsync();

                return usersDataBase;
            }
            else
            {
                return new List<User>();
            }
        }

        public async Task<User?> GetById(int id)
        {
            var userDataBase = await _dbContext.Set<User>().SingleOrDefaultAsync(user => user.Id == id);

            if (userDataBase is null)
                throw new InvalidOperationException($"User com ID {id} não encontrado");

            return userDataBase;
        }

        public async Task Add(User user)
        {
            if (user is not null && _dbContext is not null && _dbContext.Set<User>() is not null)
            {
                await _dbContext.Set<User>().AddAsync(user);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Dados inválidos...");
            }
        }

        public async Task Edit(User user)
        {
            if (user is not null)
            {
                _dbContext.Entry(user).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Dados inválidos...");
            }
        }

        public async Task Delete(int id)
        {
            var userDataBase = await GetById(id);

            if (userDataBase is not null)
            {
                _dbContext.Entry(userDataBase).State = EntityState.Deleted;
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Dados inválidos...");
            }
        }
    }
}
