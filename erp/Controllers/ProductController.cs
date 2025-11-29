using erp.Models;
using erp.Models.Context;
using erp.Services;
using Microsoft.AspNetCore.Mvc;

namespace erp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductService _service;
    
    public ProductController(ProductService service)
    {
     _service = service;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetAllProducts()
    {
        return Ok(await _service.GetProducts());
    }
}