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
using TestMaker.Entity.Concrete.Model;

namespace TestMaker.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserManager manager;

        public UserController(IUserManager manager)
        {
            this.manager = manager;
        }

        [HttpPost("CheckUser")]
        public Response<UserSessionDto> CheckUser(LoginDto login)
        {
            return manager.Find(login.UserName, login.Password);
        }
    }
}
