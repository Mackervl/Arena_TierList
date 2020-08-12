using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arena_TierList
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(long id);
        Task CreateAsync(T entity);
        void Update(T entity);
        Task DeleteAsync(long id);

    }
}
