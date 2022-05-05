using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Abstract;

namespace TestMaker.Entity.Concrete.Dto
{
    public class ExamDto : IDtoBase
    {
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List<QuestionDto> QuestionList { get; set; }
    }
}
