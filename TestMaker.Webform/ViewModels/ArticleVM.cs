using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMaker.Webform.ViewModels
{
    public class ArticleVM : IVMBase
    {
        public string title { get; set; }
        public string uri { get; set; }
        public string text { get; set; }
    }
}