namespace erp.Models;

public class Product
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int amount { get; set; }
    public double price { get; set; }
}