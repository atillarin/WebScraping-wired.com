using System;
using System.Collections.Generic;
using TestMaker.Entity.Abstract;

#nullable disable

namespace TestMaker.Entity.Concrete.Dto
{
    public class TestDto:IDtoBase
    {
        public long TestId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
        public long UserId { get; set; }

    }
}
