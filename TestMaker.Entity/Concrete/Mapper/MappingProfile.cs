
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Concrete.Dto;
using TestMaker.Entity.Concrete.Model;

namespace TestMaker.Entity.Concrete.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Test, TestDto>().ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<UserDto, UserSessionDto>();
            CreateMap<TestDto, TestSessionDto>();
        }
        
    }
}
