using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inder.Api.Core.Repository
{
    public interface IRepository<T>
    {
        void Add(T data);
        IEnumerable<T> GetAll();
        T GetById(int Id);
    }
}
