using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Abstract;
using TestMaker.Entity.Concrete;

namespace TestMaker.Bll.Abstract
{
    public interface IGenericManager<T> where T:IDtoBase
    {
        Response Add(T dto);
        Response Delete(long id);
    }
}
