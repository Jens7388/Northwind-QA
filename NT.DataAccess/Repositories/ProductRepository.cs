using Microsoft.EntityFrameworkCore;
using NT.DataAccess.RepositoryBase;
using NT.Entities.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT.DataAccess.Repositories
{
    public class ProductRepository : RepositoryBase<Products>
    {
        public override async Task<Products> GetByIdAsync(int id)
        {
            try
            {
                return await context.Products
                .Include("Category")
                .SingleOrDefaultAsync(p => p.ProductId == id);
            }
            catch
            {
                throw;
            }
        }

        public override async Task<IEnumerable<Products>> GetAllAsync()
        {
            try
            {
                return await context.Set<Products>()
                .Include("Category")
                .Where(p => p.UnitsInStock < 10)
                .ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}