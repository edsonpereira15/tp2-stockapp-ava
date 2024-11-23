using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using StockApp.Application.DTOs;
using StockApp.Domain.Entities;
using StockApp.Domain.Interfaces;


namespace StockApp.API.Controllers
{
    public class UserController
    {
        [ApiController]
        [Route("api/[Controller]")]

        public class UserController : ControllerBase
        {
            private readonly.IUserRepository userRepository;
        }

        public UserController(IUseRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]) userRegisterDto useRegisterDto)
        {
            var user = new User;
            {
                username = userRegisterDto.Username,
            PasswordHash = BCrypt.Net.BCrypt. Hashpassword(userRegisterDto.Password),
            Role = userregisterDto.Role
            };

            await userrepository.AddSync(user);
            return OK
        }

    }
}
