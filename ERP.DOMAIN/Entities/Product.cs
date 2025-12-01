using ERP.DOMAIN.Entities.Base;

namespace ERP.DOMAIN.Entities;

public class Product : EntityBase
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public int Amount { get; set; }
    public double Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}