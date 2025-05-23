using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarketDataFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {

        private readonly IChartAppService _chartAppServices;
        public ChartController(IChartAppService chartAppServices)
        {
            _chartAppServices = chartAppServices;
        }





        [HttpGet("simple-chart")]
        public async Task<IActionResult> GetSimpleChart([FromQuery] string symbol, 
                                                        [FromQuery] int limit, 
                                                        [FromQuery] string range)
        {
            return Ok(await _chartAppServices.SearchChart(symbol, limit, range));
        }

        [HttpGet("advanced-chart")]
        public async Task<IActionResult> GetAdvancedChart([FromQuery] string symbol, 
                                                          [FromQuery] int limit, 
                                                          [FromQuery] string from, 
                                                          [FromQuery] string to, 
                                                          [FromQuery] string range)
        {
            return Ok(await _chartAppServices.SearchChartAdvanced(symbol, limit, from, to, range));
        }


    }
}
