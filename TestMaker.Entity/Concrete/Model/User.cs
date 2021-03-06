using System;
using System.Collections.Generic;
using TestMaker.Entity.Abstract;

#nullable disable

namespace TestMaker.Entity.Concrete.Model
{
    public partial class User : IModelBase
    {
        public User()
        {
            Tests = new HashSet<Test>();
        }

        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long? Level { get; set; }

        public virtual ICollection<Test> Tests { get; set; }
    }
}
