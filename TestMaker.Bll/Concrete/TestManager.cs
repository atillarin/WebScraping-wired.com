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
using TestMaker.Entity.Concrete.Mapper;

namespace TestMaker.Bll.Concrete
{
    public class TestManager : ITestManager
    {
        private readonly ITestRepository testRepository;
        private readonly IQuestionRepository questionRepository;

        public TestManager(ITestRepository testRepository, IQuestionRepository questionRepository)
        {
            this.testRepository = testRepository;
            this.questionRepository = questionRepository;
        }

        public ResponseList<TestSessionDto> GetAll()
        {
            try
            {
                var result = testRepository.GetTests();
                return new ResponseList<TestSessionDto>
                {
                    Message = "Success",
                    StatusCode = StatusCodes.Status200OK,
                    Data = ObjectMapper.Mapper.Map<List<TestSessionDto>>(result)
                };
            }
            catch (Exception ex)
            {
                return new ResponseList<TestSessionDto>
                {
                    Message = $"Error {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
            
        }
        public Response Add(TestDto dto)
        {
            try
            {
                testRepository.Add(dto);
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
            try
            {
                questionRepository.Delete(id);
                testRepository.Delete(id);
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


    }
}
