using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMaker.Webform.ViewModels
{
    public class TestVM : IVMBase
    {
        public long TestId { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
    }
}