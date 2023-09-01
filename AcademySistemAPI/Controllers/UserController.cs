using AcademySistem.Domain.DTO;
using AcademySistem.Infra.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AcademySistemAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("Create")]
        public IActionResult Create(UserCreateDTO entrada)
        {
            var result = _userService.Create(entrada);
            return Ok(result);
        }
        [HttpPut("Update")]
        public IActionResult Update(UserUpdateDTO entrada)
        {
            var result = _userService.Update(entrada);
            return Ok(result);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int entrada)
        {
            var result = _userService.GetById(entrada);
            return Ok(result);
        }
    }
}
