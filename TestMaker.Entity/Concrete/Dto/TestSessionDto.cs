using System;
using System.Collections.Generic;
using TestMaker.Entity.Abstract;

#nullable disable

namespace TestMaker.Entity.Concrete.Dto
{
    public class TestSessionDto:IDtoBase
    {
        public long TestId { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }

    }
}
