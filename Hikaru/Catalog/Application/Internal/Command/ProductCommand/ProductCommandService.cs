using Hikaru.Catalog.Domain.Model.Aggregates;
using Hikaru.Catalog.Domain.Model.Commands.Product;
using Hikaru.Catalog.Domain.Model.Queries;
using Hikaru.Catalog.Domain.Repositories;
using Hikaru.Catalog.Domain.Services.Commands;
using Hikaru.Shared.Domain.Repositories;

namespace Hikaru.Catalog.Application.Internal.Command.ProductCommand;

public class ProductCommandService(
    IProductRepository productRepository,
    IUnitOfWork unitOfWork
    ): IProductCommandService
{
    
    //create Product
    public async Task<Product?> Handle(CreateProductCommand command)
    {
        var product = new Product(command);
        await productRepository.AddAsync(product);
        await unitOfWork.CompleteAsync();
        return product;

    }
    //Delete Product
    public async Task<bool> Handle(DeleteProductCommand command)
    {
        var product = await productRepository.FindByIdAsync(command.ProductId);
        if (product is null) return false;
        productRepository.Remove(product);
        await unitOfWork.CompleteAsync();
        return true;
    }
    // update Product
    public async Task<bool> Handle(UpdateProductCommand command, int productId)
    {
        var product = await productRepository.FindByIdAsync(productId);
        if (product is null)
            return false;
        product.UpdateProduct(command);
        productRepository.Update(product);
        await unitOfWork.CompleteAsync();
        return true;
    }
}