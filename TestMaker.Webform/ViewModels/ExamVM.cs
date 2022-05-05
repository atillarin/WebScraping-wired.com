using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMaker.Webform.ViewModels
{
    public class ExamVM : IVMBase
    {
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List<QuestionVM> QuestionList { get; set; }
    }
}