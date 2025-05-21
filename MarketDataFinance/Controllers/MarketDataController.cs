using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarketDataFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketDataController : ControllerBase
    {
        private readonly IDataAppServices _dataAppServices;
        public MarketDataController(IDataAppServices dataAppServices)
        {
            _dataAppServices = dataAppServices;
        }


        // GET api/<MarketDataController>/5
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            DataViewModel model = await _dataAppServices.SearchMarketETF();

            return Ok(model);
        }
    }
}
