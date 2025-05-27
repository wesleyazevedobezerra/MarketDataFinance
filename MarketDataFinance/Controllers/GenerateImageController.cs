using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.Services;
using Microsoft.AspNetCore.Mvc;
using PuppeteerSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarketDataFinance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerateImageController : ControllerBase
    {
        private readonly IScreenshotAppService _screensshotAppService;

        public GenerateImageController(IScreenshotAppService screensshotAppService)
        {
            _screensshotAppService = screensshotAppService;
        }


        // GET: api/<GenerateImageController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            string base64String = await _screensshotAppService.GetScreenshotBase64Async();
            return Ok(base64String);

        }

    }
}
