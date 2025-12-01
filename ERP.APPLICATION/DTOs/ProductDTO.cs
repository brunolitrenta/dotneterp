using ERP.DOMAIN.Entities;

namespace ERP.APPLICATION.DTOs;

public class CreateProductDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }
    public int Price { get; set; }

    public Product ToEntity()
    {
        return new Product()
        {
            Name = this.Name,
            Description = this.Description,
            Amount = this.Amount,
            Price = this.Price,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };
    }
}