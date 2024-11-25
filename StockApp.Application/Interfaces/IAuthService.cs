using StockApp.Domain.Entities;

namespace StockApp.Application.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResult> RegisterUserAsync(RegisterRequest request);
        Task<AuthResult> RefreshTokenAsync(string token);
        Task<AuthResult> LoginUserAsync(Auth0.ManagementApi.Models.Rules.LoginRequest request);
        Task<AuthResult> RegisterUserAsync(Services.RegisterRequest request);
    }

    public class AuthResult
    {
        public bool Success { get; set; }
        public string Token { get; set; }

        public AuthResult(string token)
        {
            Token = token;
        }

    }
}
