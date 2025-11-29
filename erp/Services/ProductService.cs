using erp.Models;
using erp.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace erp.Services;

public class ProductService
{
  protected readonly ErpDBContext _context;
  
  public ProductService(ErpDBContext context)
  {
    _context = context;
  }
  
  public async Task<List<Product>> GetProducts()
  {
    return await _context.Products.ToListAsync();
  }
}