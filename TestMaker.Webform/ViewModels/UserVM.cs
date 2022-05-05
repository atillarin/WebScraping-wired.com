using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMaker.Webform.ViewModels
{
    public class UserVM : IVMBase
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int Level { get; set; }
    }
}