using ERP.APPLICATION.DTOs;
using ERP.DOMAIN.Entities;

namespace ERP.APPLICATION.Services;

public interface IProductService
{
  Task<List<Product>> GetProducts(int? offset, int? limit);
  Task<Product> GetProductById(Guid id);
  Task<Product> CreateProduct(CreateProductDTO product);
  Task<Product> UpdateProduct(UpdateProductDTO product);
}
public class ProductService(IProductRepository _repository) : IProductService
{
  
  public async Task<List<Product>> GetProducts(int? offset, int? limit)
  {
    return await _repository.GetProducts(offset, limit);
  }

  public async Task<Product> GetProductById(Guid id)
  {
    return await _repository.GetProductById(id);
  }

  public async Task<Product> CreateProduct(CreateProductDTO product)
  {
    return await _repository.CreateProduct(product.ToEntity());
  }

  public async Task<Product> UpdateProduct(UpdateProductDTO product)
  {
    return await _repository.UpdateProduct(product.ToEntity());
  }
}