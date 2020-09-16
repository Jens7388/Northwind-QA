using Newtonsoft.Json;
using NT.Entities.Models;
using NT.Services.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NT.Services
{
    // Class for product services
    public class ProductService : ServiceBase
    {
        /// <summary>
        /// Returns a list of all product objects.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<List<Products>> GetAllProductsAsync()
        {
            try
            {
                // Call the web API
                string json = await CallWebApiAsync("http://10.143.74.234:5000/product/all");

                // Deserialize the JSON data into an object list
                List<Products> orderData = JsonConvert.DeserializeObject<List<Products>>(json);

                // Return the object list
                return orderData;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Returns a product by id
        /// </summary>
        /// <returns></returns>
        public virtual async Task<Products> GetProductByIdAsync(int productId)
        {
            try
            {
                // Call the web API
                string json = await CallWebApiAsync($"http://10.143.74.234:5000/product/{productId}");

                // Deserialize the JSON data into an object list
                Products product = JsonConvert.DeserializeObject<Products>(json);

                // Return the object list
                return product;
            }
            catch
            {
                throw;
            }
        }
    }
}