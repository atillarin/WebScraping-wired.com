using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMaker.Bll.Abstract;
using TestMaker.Entity.Concrete;
using TestMaker.Entity.Concrete.Dto;

namespace TestMaker.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        ITestManager manager;

        public TestController(ITestManager manager)
        {
            this.manager = manager;
        }

        [HttpGet("GetAll")]
        public ResponseList<TestSessionDto> GetAll ()
        {
            var x = manager.GetAll();
            return x;
        }
        [HttpPost("DeleteRow")]
        public Response DeleteRow(TestDto test)
        {
            var result = manager.Delete(test.TestId);
            return result;
        }
    }
}
