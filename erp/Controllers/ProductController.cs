using erp.Models;
using erp.Models.DTOs;
using erp.Models.Entities;
using erp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace erp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController(IProductService _service) : ControllerBase
{
    
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts([FromQuery] int offset = 0, [FromQuery] int limit = 10)
    {
        return Ok(await _service.GetProducts(offset, limit));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProductById([FromRoute] Guid id)
    {
        return Ok(await _service.GetProductById(id));
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct([FromBody] CreateProductDTO product)
    {
        return Ok(await _service.CreateProduct(product));
    }
}