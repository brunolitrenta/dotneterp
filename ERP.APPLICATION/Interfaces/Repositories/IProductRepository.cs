using ERP.DOMAIN.Entities;

namespace ERP.APPLICATION;

public interface IProductRepository
{
   Task<List<Product>> GetProducts(int? offset, int? limit);
   Task<Product> GetProductById(Guid id);
   Task<Product> CreateProduct(Product product);
}