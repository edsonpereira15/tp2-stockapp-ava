using System.Threading.Tasks;
using StockApp.Domain.Entities;
using StockApp.Application.Interfaces;
using Auth0.ManagementApi.Models.Rules;

namespace StockApp.Application.Services
{
    public class AuthService : IAuthService
    {
        public AuthService()
        {
        }

        // Registro de usuário

        public async Task<AuthResult> RegisterUserAsync(RegisterRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return await Task.FromResult(result: new AuthResult { Success = true });
        }

        // Login do usuário
        public async Task<AuthResult> LoginUserAsync(LoginRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return await Task.FromResult(new AuthResult { Success = true, Token = "Sample Token" });
        }

        // Atualização do usu[ario
        public async Task<AuthResult> RefreshTokenAsync(string token)
        {
            return await Task.FromResult(new AuthResult { Success = true, Token = "NewSampleToken" });
        }

        Task<AuthResult> IAuthService.RefreshTokenAsync(string token )
        {
            throw new NotImplementedException();
        }

        public Task<AuthResult> RegisterUserAsync(RegisterRequest request) => throw new NotImplementedException();

        Task<AuthResult> IAuthService.RegisterUserAsync(RegisterRequest request)
        {
            throw new NotImplementedException();
        }

        Task<AuthResult> IAuthService.RegisterUserAsync(RegisterRequest request)
        {
            throw new NotImplementedException();
        }

        Task<AuthResult> IAuthService.LoginUserAsync(LoginRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
