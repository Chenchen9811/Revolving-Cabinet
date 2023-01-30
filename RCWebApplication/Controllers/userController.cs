using Dm;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Model.Other;
using Model.Vo;
using RCWebApplication.CfgFile;
using Service;


namespace RCWebApplication.Controllers
{
    [Route("[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        public ITokenUtil TokenUtil;
        public UserService userService;

        public UserController(ILogger<UserController> logger, ITokenUtil tokenUtil, UserService userService)
        {
            _logger = logger;
            TokenUtil = tokenUtil;
            this.userService = userService;
        }



        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("this is a get request!");
            return "this is a get request!";
        }

        [HttpPost]
        public ApiResult login(LoginVo loginVo)
        {
            // 参数校验
            if (loginVo == null || string.IsNullOrEmpty(loginVo.account)) {
                _logger.LogError("参数验证失败！");
                return ResultHelper.failed("参数验证失败！");
            } 
            // 检索用户
            SysUser sysUser = new SysUser();
            try {
                sysUser = userService.findSysUserByAccount(loginVo.account);
            }
            catch(Exception ex) {
                _logger.LogError(CommonConstants.MSG_E_LOG_002);
                return ResultHelper.failed(CommonConstants.MSG_E_LOG_002);
            }

            // 验证账号和密码


            
            
            return null;
        }

    }
}
