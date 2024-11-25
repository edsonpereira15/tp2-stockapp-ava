using StockApp.Application.Services;
using StockApp.Application;
using StockApp.Application.Repositories;
namespace StockApp.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(Guid userId);
        Task <IEnumerable<User>> GetAllUsersAsync();
        Task AddUserAsync(Guid userId);
        Task UpdateUserAsync(Guid userId);
        Task DeleteUserAsync(Guid userId);

    }
}
