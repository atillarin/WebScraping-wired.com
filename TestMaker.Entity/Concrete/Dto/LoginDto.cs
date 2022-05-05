using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Abstract;

namespace TestMaker.Entity.Concrete.Dto
{
    public class LoginDto:IDtoBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
