using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Divisors.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisorsController : ControllerBase
    {
        private readonly ILogger<DivisorsController> _logger;

        public DivisorsController(ILogger<DivisorsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Divisors of a number")]
        public Divisors Get(uint number)
        {           
            return Service.DivisorsChecker(number);
        }
        
    }

}