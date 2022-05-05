using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Abstract;

namespace TestMaker.Entity.Concrete.Dto
{
    public class ArticleDto:IDtoBase
    {
        public string title { get; set; }
        public string uri { get; set; }
        public string text { get; set; }
    }
}
