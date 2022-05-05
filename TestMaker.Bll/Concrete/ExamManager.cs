using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Bll.Abstract;
using TestMaker.Dal.Abstract;
using TestMaker.Entity.Concrete;
using TestMaker.Entity.Concrete.Dto;

namespace TestMaker.Bll.Concrete
{
    public class ExamManager : IExamManager
    {
        private readonly ITestRepository testRepository;
        private readonly IQuestionRepository questionRepository;
        TestDto test;

        public ExamManager(ITestRepository testRepository, IQuestionRepository questionRepository)
        {
            this.testRepository = testRepository;
            this.questionRepository = questionRepository;
        }


        public Response CreateExam(ExamDto exam)
        {

            test = new TestDto();
            test.Text = exam.Text;
            test.Title = exam.Title;
            test.Date = (DateTime.Today).ToShortDateString();
            test.UserId = exam.UserID;

            try
            {
                long testID = testRepository.Insert(test);  // test tablosu kaydı yapılır
                foreach (var question in exam.QuestionList) //exam nesnesindeki tüm sorular testid si ile birlikte kayıt edilir
                {
                    question.TestId = testID;
                    questionRepository.Add(question);
                }
                return new Response
                {
                    Message = "Success",
                    StatusCode = StatusCodes.Status200OK,
                    Data = null
                };

            }
            catch (Exception ex)
            {
                return new Response
                {
                    Message = $"Error: {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                
                };
            }

            

        }

    }
}
