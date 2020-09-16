using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NT.Entities.Models;
using NT.Services.Base;

namespace NT.Services
{
    // Class for order Services
    public class OrderService : ServiceBase
    {
        /// <summary>
        /// Returns a list of all order objects.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<List<Orders>> GetAllOrdersAsync()
        {
            try
            {
                // Call the web API
                string json = await CallWebApiAsync("http://10.143.74.234:500/order/all");

                // Deserialize the JSON data into an object list
                List<Orders> orderData = JsonConvert.DeserializeObject<List<Orders>>(json);

                // Return the object list
                return orderData;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Returns a list of all order objects by ID.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<List<Orders>> GetOrderByIdAsync(string customerId)
        {
            try
            {
                // Call the web API
                string json = await CallWebApiAsync($"http://10.143.74.234:5000/order/{customerId}");

                // Deserialize the JSON data into an object list
                List<Orders> orders = JsonConvert.DeserializeObject<List<Orders>>(json);

                // Return the object list
                return orders;
            }
            catch
            {
                throw;
            }
        }
    }
}