using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMaker.Bll.Concrete;
using TestMaker.Entity.Concrete.Dto;

namespace TestMaker.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WiredController : ControllerBase
    {
        WiredDataManager manager = new WiredDataManager();

        [HttpGet("GetArticles")]
        public List<ArticleDto> GetArticles()
        {
            var x=  manager.GetArticles();
            return x;
        }
    }
}
