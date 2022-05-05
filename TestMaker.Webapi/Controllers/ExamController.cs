using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMaker.Bll.Abstract;
using TestMaker.Bll.Concrete;
using TestMaker.Entity.Concrete;
using TestMaker.Entity.Concrete.Dto;

namespace TestMaker.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        IExamManager manager;

        public ExamController(IExamManager manager)
        {
            this.manager = manager;
        }

        [HttpPost("Create")]
        public Response CreateExam(ExamDto exam)
        {
            var result = manager.CreateExam(exam);
            return result;
        }
    }
}
