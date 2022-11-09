using Academia76721.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Repositories
{
    public abstract class BaseCRUD<T, K> : ICRUD<T, K>
    {
        public T Delete(K id)
        {
            throw new NotImplementedException();
        }

        public T GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetOne(K id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T item)
        {
            throw new NotImplementedException();
        }

        public T Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
