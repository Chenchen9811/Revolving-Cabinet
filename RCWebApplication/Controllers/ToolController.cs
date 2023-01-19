using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using SqlSugar;

namespace RCWebApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ToolController : ControllerBase
    {
        public SqlSugarClient _db;

        public ToolController(SqlSugarClient db) {

            _db = db;
        }
          
        [HttpGet]
        public string InitDataBase()
        {
            string res = "ok";
            _db.DbMaintenance.CreateDatabase();
            return res;
        }
    }

}
