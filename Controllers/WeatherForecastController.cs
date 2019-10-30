using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly DataContext _logger;

        public WeatherForecastController(DataContext logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values= await _logger.Values.ToListAsync();
            return Ok(values);
            
        }
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id){
            var value=await _logger.Values.FirstOrDefaultAsync(x => x.Id== id);

            return Ok(value);   
        }
    }
}
