using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Concrete;
using TestMaker.Entity.Concrete.Dto;
using TestMaker.Entity.Concrete.Model;

namespace TestMaker.Bll.Abstract
{
    public interface IUserManager : IGenericManager<UserDto>
    {
        Response<UserSessionDto> Find(string user, string pass);
    }
}
