using NT.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NT.DataAccess.RepositoryBase
{
    public interface IRepositoryBase<T>
    {
        NorthwindContext Context { get; set; }

        Task AddAsync(T t);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task UpdateAsync();
        Task DeleteAsync(T t);
    }
}