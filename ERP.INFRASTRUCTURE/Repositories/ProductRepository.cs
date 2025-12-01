using ERP.APPLICATION;
using ERP.DOMAIN.Entities;
using ERP.INFRASTRUCTURE.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ERP.INFRASTRUCTURE.Repositories;

public class ProductRepository(ErpDBContext _context) : IProductRepository
{
    public async Task<List<Product>> GetProducts(int? offset, int? limit)
    {
        var queryBuilder = _context.Products.AsQueryable();
        if (offset.HasValue) queryBuilder = queryBuilder.Skip(offset.Value);
        if (limit.HasValue) queryBuilder = queryBuilder.Take(limit.Value);
        return await queryBuilder.ToListAsync();
    }

    public async Task<Product> GetProductById(Guid id)
    {
        return await _context.Products.FindAsync(id) ?? throw new KeyNotFoundException();
    }

    public async Task<Product> CreateProduct(Product product)
    {
        var result = await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        return result.Entity;
    }
}