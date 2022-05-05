
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public class UserRepository : IUserRepository
    {
        private readonly defaultContext context;

        public UserRepository(defaultContext context)
        {
            this.context = context;
        }

        public UserDto Find(string userName, string pass)
        {
            return ObjectMapper.Mapper.Map<UserDto>(context.Users.FirstOrDefault(user => user.UserName == userName & user.Password == pass));
        }

        public void Add(UserDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        
    }
}
