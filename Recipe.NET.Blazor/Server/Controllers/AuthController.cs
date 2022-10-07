using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recipe.NET.Application.Dtos;
using Recipe.NET.Application.Interface;
using Recipe.NET.Application.Response;
using Recipe.NET.Domain.Entity;

namespace Recipe.NET.Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("login")]
        public async Task<ActionResult<BaseResponse<string>>> Login(UserLoginDto userLogin)
        {
            var response = await _userRepository.Login(userLogin.Email, userLogin.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            
            return Ok(response);
        }


        [HttpPost("register")]
        public async Task<ActionResult<BaseResponse<int>>> Register(UserRegisterDto userRegister)
        {
            var response = await _userRepository.Register(new User
            {
                Email = userRegister.Email
            }, userRegister.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
