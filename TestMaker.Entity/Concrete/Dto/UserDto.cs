using System;
using System.Collections.Generic;
using TestMaker.Entity.Abstract;

#nullable disable

namespace TestMaker.Entity.Concrete.Dto
{
    public class UserDto: IDtoBase
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long? Level { get; set; }

    }
}
