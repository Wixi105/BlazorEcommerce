using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
    private readonly DataContext _context;

    public ProductController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
    { 
        var Products = await _context.Products.ToListAsync();
        var response = new ServiceResponse<List<Product>>() { Data= Products};

        return Ok(response);
    }





}

