using ERP.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace ERP.INFRASTRUCTURE.Persistence;

public class ErpDBContext : DbContext
{
    public ErpDBContext(DbContextOptions<ErpDBContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}