using Microsoft.EntityFrameworkCore;
using NT.DataAccess.RepositoryBase;
using NT.Entities.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT.DataAccess.Repositories
{
    public class OrderRepository : RepositoryBase<Orders>
    {
        public async Task<IEnumerable<Orders>> GetByIdAsync(string customerId)
        {
            try
            {
                return await context.Set<Orders>()
                .Include("Customer")
                .Include("OrderDetails")
                .Where(o => o.CustomerId == customerId)
                .ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public override async Task<IEnumerable<Orders>> GetAllAsync()
        {
            try
            {
                return await context.Set<Orders>()
                .Include("Customer")
                .Include("OrderDetails")
                .Where(o => o.ShippedDate == null)
                .ToListAsync();
            }
            catch
            {
                throw;
            }         
        }
    }
}