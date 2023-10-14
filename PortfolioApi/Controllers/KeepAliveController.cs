using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Controllers.Base;
using PortfolioApi.Models.Blog;
using PortfolioApi.Services;
using PortfolioApi.Services.Interface;

namespace PortfolioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KeepAliveController : BaseController
    {
        public KeepAliveController() 
        {
        }

        [HttpGet]
        public ActionResult<string> KeepAlive()
        {
            return Ok("Keep alive");
        }
    }
}
