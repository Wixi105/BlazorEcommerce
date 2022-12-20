using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
    { 
        var result = await _productService.GetProductsAsync();
        return Ok(result);
    }

    [HttpGet("{productID}")]
    
    //another way of accessing the route item
    //[Route("{id}")]
    public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productID)
    {
        var result = await _productService.GetProductAsync(productID);
        return Ok(result);
    }




}

