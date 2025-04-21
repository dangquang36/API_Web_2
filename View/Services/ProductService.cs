using API_Web_2.Data;

namespace View.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {

            this._httpClient = httpClient;
        }

        public async Task<List<Product>> GetPAllroducts()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("Products");
        }
        public async Task<Product> GetProductById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"Products/{id}");
        }
        public async Task CreateProduct(Product product)
        {
            var response = await _httpClient.PostAsJsonAsync("Products", product);
            response.EnsureSuccessStatusCode();
        }
        public async Task UpdateProduct(Product product)
        {
            var response = await _httpClient.PutAsJsonAsync($"Products/{product.ID}", product);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteProduct(int id)
        {
            var response = await _httpClient.DeleteAsync($"Products/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
