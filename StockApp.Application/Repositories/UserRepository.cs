using System.Threading.Tasks;
using StockApp.Application.Interfaces;
using StockApp.Domain.Entities;

namespace StockApp.Application.Repositories
{
    public class UserRepository: IUserRepository
    {
        // Implementação para usuário via Id
        public async Task<User> GetUserByIdAsync(Guid userId)
        {
            return await Task.FromResult(new User { Id = userId, Name = "Sample User" });
        }

        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            return await Task.FromResult(new List<User>());
        }

        public async Task AddUserAsync(User user)
        {
            await Task.CompletedTask;
        }

        public async Task UpdateUserAsync(User user)
        {
            await Task.CompletedTask;
        }

        public async Task DeleteUserAsync(Guid userId)
        {
            await Task.CompletedTask;
        }

        Task<IEnumerable<User>> IUserRepository.GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        Task IUserRepository.AddUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        Task IUserRepository.UpdateUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
