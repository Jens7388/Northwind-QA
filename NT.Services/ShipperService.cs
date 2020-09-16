using Newtonsoft.Json;
using NT.Entities.Models;
using NT.Services.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NT.Services
{
    // Class for order Services
    public class ShipperService : ServiceBase
    {
        /// <summary>
        /// Returns a list of all order objects.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<List<Shippers>> GetAllShippersAsync()
        {
            try
            {
                // Call the web API
                string json = await CallWebApiAsync("http://10.143.74.234:5000/shipper/all");

                // Deserialize the JSON data into an object list
                List<Shippers> shipperData = JsonConvert.DeserializeObject<List<Shippers>>(json);

                // Return the object list
                return shipperData;
            }
            catch
            {
                throw;
            }
        }
    }
}