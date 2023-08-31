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
        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            try
            {
                var result = _userService.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int entrada)
        {
            try
            {
                var result = _userService.Delete(entrada);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
