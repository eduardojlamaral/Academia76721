using Academia76721.Domain.Common;
using Academia76721.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Repositories
{
    public abstract class BaseCRUD<T, K> : ICRUD<T, K> where T: BaseEntity<K>
    {

        private readonly IList<T> _items = new List<T>();
        public T Delete(K id)
        {
            throw new NotImplementedException();
        }

        // Tenho uma duvida aqui
        public T GetAll()
        {
            return default;
        }

        public T GetOne(K id)
        {
            return _items.First(p=>p.Id.Equals(id));
        }

        public T Insert(T item)
        {
            throw new NotImplementedException();
        }

        public T Update(T item)
        {
            throw new NotImplementedException();
        }

        IList<T> ICRUD<T, K>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
