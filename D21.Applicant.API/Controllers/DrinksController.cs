using D21.Applicant.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace D21.Applicant.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrinksController : ControllerBase
    {
        public DrinksController()
        {
        }

        [HttpGet(Name = "all")]
        public IEnumerable<Drink> Get()
        {
            var drinks = new List<Drink>()
            {
               new Drink()
               {
                   Name = "CocaCola",
                   Description = "a carbonated soft drink manufactured by the Coca-Cola Company",
                   _uuid = Guid.NewGuid()
               },
               new Drink()
               {
                    Name = "Mountain Dew",
                    _uuid = Guid.NewGuid(),
                    Description = "carbonated soft drink brand produced and owned by PepsiCo"
               }
            };

            return drinks;
        }
    }
}