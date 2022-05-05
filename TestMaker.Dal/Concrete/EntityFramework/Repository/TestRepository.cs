using Microsoft.EntityFrameworkCore;
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
    public class TestRepository : ITestRepository
    {
        private readonly defaultContext context;

        public TestRepository(defaultContext context)
        {
            this.context = context;
        }

        public List<TestDto> GetTests()
        {
            return ObjectMapper.Mapper.Map<List<TestDto>>(context.Tests.ToList());
        }

        public long Insert(TestDto dto)
        {
            context.Entry(ObjectMapper.Mapper.Map<Test>(dto)).State = EntityState.Added;

            if (context.SaveChanges() == 1)  //kayıt başarılıysa 
            {
                return context.Tests.Max<Test>(t => t.TestId);  // son kayıt idsi ni al
            }
            return 0;
        }

        public void Delete(long id)
        {
            context.Remove(context.Tests.First(t => t.TestId == id));
            context.SaveChanges();
        }

        public TestDto Find(TestDto dto)
        {
            throw new NotImplementedException();
        }

        public void Add(TestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
