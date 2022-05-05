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
    public class QuestionManager : IQuestionManager
    {
        private readonly IQuestionRepository repository;

        public QuestionManager(IQuestionRepository repository)
        {
            this.repository = repository;
        }

        public Response Add(QuestionDto dto)
        {
            try
            {
                repository.Add(dto);
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
                    Message = $"Error {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }

        public Response Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
