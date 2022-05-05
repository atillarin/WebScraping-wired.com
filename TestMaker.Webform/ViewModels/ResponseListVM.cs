using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaker.Webform.ViewModels
{
    public class ResponseListVM<T> where T : IVMBase
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public List<T> Data { get; set; }
    }
}
