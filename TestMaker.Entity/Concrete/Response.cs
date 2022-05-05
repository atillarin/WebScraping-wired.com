using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Abstract;

namespace TestMaker.Entity.Concrete
{
    public class Response<T> where T: IDtoBase
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; }
    }
    public class Response 
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public object Data { get; set; }
    }



}
