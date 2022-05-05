using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Concrete.Dto;

namespace TestMaker.Dal.Abstract
{
    public interface IQuestionRepository : IGenericRepository<QuestionDto>
    {
    }
}
