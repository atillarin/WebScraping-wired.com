using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Abstract;

namespace TestMaker.Entity.Concrete.Dto
{
    public class UserSessionDto : IDtoBase
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public long? Level { get; set; }
    }
}
