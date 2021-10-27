using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment2WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Assignment2WebAPI.Controllers
{   [ApiController]
    [Route("[controller]")]
    public class AdultsController:ControllerBase
    {
        private IAdult adultService;

        public AdultsController(IAdult adult)
        {
            Console.WriteLine("aleo bleadi");
            adultService = adult;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults()
        {
            try
            {
                Console.WriteLine("lalalalalalala");
                IList<Adult> adults = await adultService.GetAsync();
               Console.WriteLine(adults.Count+"lalalalalalala");
                string Json = JsonSerializer.Serialize(adults);
                return Ok(Json);
            }
            catch (Exception e)
            {
                Console.WriteLine(5);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult)
        {
            try
            {
                await adultService.AddAsync(adult);
                Console.WriteLine("Added" + adult.LastName );
                return Created($"/{adult.Id}", adult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

    }
}