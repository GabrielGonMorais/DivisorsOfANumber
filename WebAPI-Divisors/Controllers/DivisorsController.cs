using Microsoft.AspNetCore.Mvc;
using WebAPI_Divisors.Services;

namespace WebAPI_Divisors.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisorsController : ControllerBase
    {       

        [HttpGet(Name = "Divisors of a number")]
        public Divisors Get(uint number)
        {           
            return Service.DivisorsChecker(number);
        }
        
    }

}