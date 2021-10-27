using System;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment2WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Assignment2WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUser userService;

        public UserController(IUser user)
        {
            userService = user;
        }

        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string? userName, [FromQuery] string? password)
        {
            
            try
            {
                User user = await userService.ValidateUser(userName, password);
                string Json = JsonSerializer.Serialize(user);
                  
                return Ok(Json);
            }
            catch (Exception e)
            {
                Console.WriteLine(3);
                return BadRequest(e.Message);
            }
        }


    }
}