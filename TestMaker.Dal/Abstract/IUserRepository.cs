using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Concrete.Dto;
using TestMaker.Entity.Concrete.Model;

namespace TestMaker.Dal.Abstract
{
    public interface IUserRepository :IGenericRepository<UserDto>
    {
        UserDto Find(string user, string pass);
    }
}
