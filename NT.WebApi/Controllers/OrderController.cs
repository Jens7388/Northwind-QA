using Microsoft.AspNetCore.Mvc;

using NT.DataAccess.Repositories;
using NT.Entities.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace NT.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController
    {
        [HttpGet("all")]
        public async Task<IEnumerable<Orders>> GetAllAsync()
        {
            try
            {
                return await new OrderRepository().GetAllAsync();
            }
            catch
            {
                throw;
            }

        }

        [HttpGet("all/{customerID}")]
        public async Task<IEnumerable<Orders>> GetAllByIdAsync(string customerId)
        {
            try
            {
                return await new OrderRepository().GetByIdAsync(customerId);
            }
            catch
            {
                throw;
            }
        }
    }
}