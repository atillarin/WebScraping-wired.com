using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Dal.Abstract;
using TestMaker.Dal.Concrete.EntityFramework.Context;
using TestMaker.Entity.Concrete.Dto;
using TestMaker.Entity.Concrete.Mapper;
using TestMaker.Entity.Concrete.Model;

namespace TestMaker.Dal.Concrete.EntityFramework.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly defaultContext context;

        public QuestionRepository(defaultContext context)
        {
            this.context = context;
        }

        public void Add(QuestionDto dto)
        {
            context.Questions.Add(ObjectMapper.Mapper.Map<Question>(dto));
            context.SaveChanges();
        }

        public void Delete(long id)
        {
            List<Question> questionList = new List<Question>();
            var x = context.Questions.Where(q => q.TestId == id).ToList();
            context.Questions.RemoveRange(x);
        }

        public QuestionDto Find(QuestionDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
