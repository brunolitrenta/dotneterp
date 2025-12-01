using erp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace erp.Models.Context;

public class ErpDBContext : DbContext
{
    public ErpDBContext(DbContextOptions<ErpDBContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}