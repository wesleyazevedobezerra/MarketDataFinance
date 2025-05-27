using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarketDataFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceChartController : ControllerBase
    {
        private readonly IFinanceChartAppService _financechartAppServices;
        public FinanceChartController(IFinanceChartAppService financechartAppServices)
        {
            _financechartAppServices = financechartAppServices;
        }


        [HttpGet("finance-chart")]
        public async Task<IActionResult> GetFinanceChart([FromQuery] string symbol,
                                                          [FromQuery] string region,
                                                          [FromQuery] string lang,
                                                          [FromQuery] string interval,
                                                          [FromQuery] string range)
        {
            return Ok(await _financechartAppServices.SearchChartFinance(symbol, region, lang, interval, range));
        }
    }
}
