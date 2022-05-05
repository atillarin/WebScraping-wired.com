using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Concrete;
using TestMaker.Entity.Concrete.Dto;

namespace TestMaker.Bll.Abstract
{
    public interface ITestManager: IGenericManager<TestDto>
    {
        ResponseList<TestSessionDto> GetAll();
    }
}
