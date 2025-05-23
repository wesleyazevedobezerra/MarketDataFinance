using MarketDataFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarketDataFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchNewsController : ControllerBase
    {
        private readonly ISearchNewsAppService _searchNewsAppServices;
        public SearchNewsController(ISearchNewsAppService searchNewsAppServices)
        {
            _searchNewsAppServices = searchNewsAppServices;
        }





        [HttpGet("search")]
        public async Task<IActionResult> GetSearchNews([FromQuery] string keyword,
                                                        [FromQuery] int limit)
        {
            return Ok(await _searchNewsAppServices.SearchNews(keyword, limit));
        }



    }
}
