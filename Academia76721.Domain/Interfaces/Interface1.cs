using Academia76721.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Interfaces
{
    public interface IGenericRepository<T,K> where T : BaseEntity<K>
    {
        Task<T> GetEntityById(K id);
        Task<IList<T>> GetAllEntities();
        Task<T> AddEntity(T entity);
        Task<T> UpdateEntity(T entity);
        Task<T> DeleteEntity(K id);
    }
}
