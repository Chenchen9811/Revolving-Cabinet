using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using SqlSugar;

namespace RCWebApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ISqlSugarClient db;
        public TestController(ISqlSugarClient db)
        {
            this.db = db;
        }

        [HttpGet]
        public string Get()
        {
            var a = db.Queryable<SysUser>().ToList();
            var b = db.Queryable<SysUser>().Where(user => user.user_id == 637971041373448836).ToList();
            Console.WriteLine(b.ToString());
            return "ok";
        }
    }
}
