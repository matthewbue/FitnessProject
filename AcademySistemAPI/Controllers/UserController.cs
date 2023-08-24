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
    }
}
