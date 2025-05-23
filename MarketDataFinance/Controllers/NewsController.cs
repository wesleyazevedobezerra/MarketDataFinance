using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.Services;
using MarketDataFinance.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarketDataFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsAppService _newsAppService;

        public NewsController(INewsAppService newsAppService)
        {
            _newsAppService = newsAppService;
        }


        // GET api/<NewsController>/5

        [HttpGet("detail")]   //api/MarketData/etf
        public async Task<IActionResult> GetDetail()
        {
            RootNewsViewModel model = await _newsAppService.SearchMarketNewsDetail();

            return Ok(model);
        }

        [HttpGet("hot")] //api/MarketData/news
        public async Task<IActionResult> GetOptionHot([FromQuery] int limit)
        {
            return Ok(await _newsAppService.SearchMarketNewsHot(limit));
        }

        [HttpGet("list")] //api/MarketData/news
        public async Task<IActionResult> GetOptionList([FromQuery] int limit)
        {
            return Ok(await _newsAppService.SearchMarketNewsList(limit));
        }
    }
}
