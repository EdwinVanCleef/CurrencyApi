using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CurrencyApp.Data;

namespace CurrencyApp.Controllers
{
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        [HttpGet]
        [Route("country/currency/all")]
        public IActionResult GetAll()
        {
            if (CurrencyData.Currencies.Count == 0)
                return NotFound("No data available");

            return Ok(CurrencyData.Currencies);
        }

        [HttpGet]
        [Route("country/currency")]
        public IActionResult Get(string match)
        {
            if (string.IsNullOrWhiteSpace(match))
                return BadRequest("Specify a Country");

            var currencyList = CurrencyData.Currencies.Where(
                x => x.Name.ToUpper().Equals(match.ToUpper()));

            if (currencyList.Count() == 0)
                return NotFound("Country not found");

            return Ok(currencyList);
        }
    }
}