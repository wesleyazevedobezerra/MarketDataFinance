using MarketDataFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarketDataFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummaryController : ControllerBase
    {

        private readonly ISummaryAppService _summaryAppService;

        public SummaryController(ISummaryAppService summaryAppService)
        {
            _summaryAppService = summaryAppService;
        }


        // GET api/<SummaryController>/5
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string symbol)
        {
            return Ok(await _summaryAppService.SearchMarketSummary(symbol));
        }

       
    }
}
