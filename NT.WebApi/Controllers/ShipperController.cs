using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using NT.DataAccess.Repositories;
using NT.Entities.Models;

namespace NT.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShipperController: Controller
    {
        [HttpGet("all")]
        public async Task<IEnumerable<Shippers>> GetAllAsync()
        {
            try
            {
                return await new ShipperRepository().GetAllAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}