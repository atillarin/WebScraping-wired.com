using System;
using System.Collections.Generic;
using TestMaker.Entity.Abstract;

#nullable disable

namespace TestMaker.Entity.Concrete.Dto
{
    public class QuestionDto:IDtoBase
    {
        public long QuestionId { get; set; }
        public string Question1 { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public long Answer { get; set; }
        public long TestId { get; set; }

    }
}
