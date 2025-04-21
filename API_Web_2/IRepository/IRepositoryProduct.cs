using API_Web_2.Data;

namespace API_Web_2.IRepository
{
    public interface IRepositoryProduct
    {
        
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task CreateProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id);
    }
}
