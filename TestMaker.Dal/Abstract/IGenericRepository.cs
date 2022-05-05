using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Abstract;

namespace TestMaker.Dal.Abstract
{
    public interface IGenericRepository<T> where T : IDtoBase
    {
        void Add(T dto);
        void Delete(long id);
    }
}
