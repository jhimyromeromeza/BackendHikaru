using System.Net.Mime;
using Hikaru.Catalog.Domain.Model.Commands.Product;
using Hikaru.Catalog.Domain.Model.Queries;
using Hikaru.Catalog.Domain.Services.Commands;
using Hikaru.Catalog.Domain.Services.Queries;
using Hikaru.Catalog.Interfaces.REST.Resources;
using Hikaru.Catalog.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace Hikaru.Catalog.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class ProductsController(
    IProductCommandService productCommandService,
    IProductQueryService productQueryService
    ): ControllerBase
{
    //Obtener todos los productos
    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var getAllProductsQuery = new GetAllProductsQuery();
        var products = await productQueryService.Handle(getAllProductsQuery);
        return Ok(products);
    }
    
    // crear Producto
    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductResource resource)
    {
        var createProductCommand = CreateProductCommandFromResource.ToCommandFromResource(resource);
        var result = await productCommandService.Handle(createProductCommand);
        if (result is null)
            return BadRequest();
        return Ok(result);
    }
    
    //Eliminar Producto
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var deleteProductCommand = new DeleteProductCommand(id);
        var result = await productCommandService.Handle(deleteProductCommand);
        if (!result)
            return NotFound(new
            {
                Message = "Producto no encontrado"
            });
        return NoContent();
    }
    
    //Update Product
    [HttpPut("{productId}")]
    public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductResource resource, int productId)
    {
        var updateProductCommand = UpdateProductCommandFromResource.ToCommandFromResource(resource);
        var result = await productCommandService.Handle(updateProductCommand, productId);
        if (!result)
            return NotFound(new
            {
                Message = "Producto no encontrado"
            });
        return NoContent();
    }
    
    // Obtener Product por Id 
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
        var getProductByIdQuery = new GetProductByIdQuery(id);
        var result = await productQueryService.Handle(getProductByIdQuery);
        return Ok(result);
    }
}