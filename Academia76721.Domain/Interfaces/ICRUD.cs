using Academia76721.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Interfaces
{
    public interface ICRUD<T,K>
    {
        T GetOne(K id);
        T Insert(T item);
        T Update(T item);
        T Delete(K id);
        IList<T> GetAll();

    }
}
