using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMaker.Webform.ViewModels
{
    public class LoginVM : IVMBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}