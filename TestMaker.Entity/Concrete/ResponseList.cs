using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Abstract;

namespace TestMaker.Entity.Concrete
{
    public class ResponseList<T> where T: IDtoBase
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public List<T> Data { get; set; }
    }



}
