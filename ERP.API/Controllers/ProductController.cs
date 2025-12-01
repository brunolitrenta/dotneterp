using ERP.APPLICATION.DTOs;
using ERP.APPLICATION.Services;
using ERP.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ERP.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController(IProductService _service) : ControllerBase
{
    
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts([FromQuery] int? offset, [FromQuery] int? limit)
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

    [HttpPut]
    public async Task<ActionResult<Product>> UpdateProduct([FromBody] UpdateProductDTO product)
    {
        return Ok(await _service.UpdateProduct(product));
    }
}