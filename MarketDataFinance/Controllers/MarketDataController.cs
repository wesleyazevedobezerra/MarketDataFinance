using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarketDataFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Change", AuthenticationSchemes = "Bearer")]
    public class MarketDataController : ControllerBase
    {
        private readonly IDataAppServices _dataAppServices;
        public MarketDataController(IDataAppServices dataAppServices)
        {
            _dataAppServices = dataAppServices;
        }


        // GET api/<MarketDataController>/5
        [HttpGet("etf")]   //api/MarketData/etf
        public async Task<IActionResult> GetETF()
        {
            RootViewModel model = await _dataAppServices.SearchMarketETF();

            return Ok(model);
        }

        [HttpGet("crypto")]   //api/MarketData/etf
        public async Task<IActionResult> GetCrypto()
        {
            RootViewModel model = await _dataAppServices.SearchMarketCrypto();

            return Ok(model);
        }


        [HttpGet("overview")]   //api/MarketData/overview
        public async Task<IActionResult> GetOverView()
        {
            RootViewModel model = await _dataAppServices.SearchMarketOverview();

            return Ok(model);
        }

    }
}
