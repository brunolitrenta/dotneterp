using erp.Models;
using erp.Models.Context;
using erp.Models.DTOs;
using erp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace erp.Services;

public interface IProductService
{
  Task<List<Product>> GetProducts(int offset, int limit);
  Task<Product> GetProductById(Guid id);
  Task<Product> CreateProduct(CreateProductDTO product);
}
public class ProductService(ErpDBContext _context) : IProductService
{
  
  public async Task<List<Product>> GetProducts(int offset, int limit)
  {
    return await _context.Products.Skip(offset).Take(limit).ToListAsync();
  }

  public async Task<Product> GetProductById(Guid id)
  {
    var product = await _context.Products.FindAsync(id) ?? throw new Exception("Produto não encontrado");

    return product;
  }

  public async Task<Product> CreateProduct(CreateProductDTO product)
  {
    var result = await _context.Products.AddAsync(product.ToEntity());
    await _context.SaveChangesAsync();
    return result.Entity;
  }
}