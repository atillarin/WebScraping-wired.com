using System;
using System.Collections.Generic;
using TestMaker.Entity.Abstract;

#nullable disable

namespace TestMaker.Entity.Concrete.Model
{
    public partial class Test : IModelBase
    {
        public Test()
        {
            Questions = new HashSet<Question>();
        }

        public long TestId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
        public long UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
