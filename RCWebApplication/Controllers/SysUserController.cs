using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RCWebApplication.Controllers
{
    [Route("[controller]/[Action]")]
    [ApiController]
    public class SysUserController : ControllerBase
    {

        private readonly ILogger<SysUserController> _logger;

        public SysUserController(ILogger<SysUserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("this is a get request!");
            return "this is a get request!";
        }



    }
}
