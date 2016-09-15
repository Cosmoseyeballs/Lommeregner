using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    public class ProductServiceClient
    {
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://webapi-backend-ws.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("produkter");
                if (response.IsSuccessStatusCode)
                {
                    Product product = await response.Content
                        .ReadAsAsync<Product>();
                    Debug.WriteLine("{0}\t${1}\t{2}",
                        product.Name, product.Price, product.Category);
                }

            }
            return new List<Product>();

        }
        public async Task<Product> GetProduct(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://webapi-backend-ws.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("produkter/" + id);
                if (response.IsSuccessStatusCode)
                {
                    Product product = await response.Content
                        .ReadAsAsync<Product>();
                    Debug.WriteLine("{0}\t${1}\t{2}",
                        product.Name, product.Price, product.Category);
                }

            }
            return new Product();

        }
    }
}
