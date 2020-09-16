using Microsoft.AspNetCore.Mvc;

using NT.DataAccess.Repositories;
using NT.Entities.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace NT.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController
    {
        [HttpGet("all")]
        public async Task<IEnumerable<Products>> GetAllAsync()
        {
            try
            {
                return await new ProductRepository().GetAllAsync();
            }
            catch
            {
                throw;
            }
        }

        [HttpGet("{productId}")]
        public async Task<Products> GetByIdAsync(int productId)
        {
            try
            {
                return await new ProductRepository().GetByIdAsync(productId);
            }
            catch
            {
                throw;
            }
        }
    }
}