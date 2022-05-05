using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaker.Webform.ViewModels
{
    public class ResponseVM<T> where T : IVMBase
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; }
    }
    public class ResponseVM
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public object Data { get; set; }
    }
}
