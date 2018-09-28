using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.API.Controllers
{
    /// <summary>
    /// 用户控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// 保存
        /// </summary> 
        [HttpPost]
        public int Save()
        {
            return 1;
        }

        /// <summary>
        /// 获取
        /// </summary> 
        [HttpGet]
        public string Get()
        {
            return "{ \"name\":\"zhangsan\"}";
        }
    }
}