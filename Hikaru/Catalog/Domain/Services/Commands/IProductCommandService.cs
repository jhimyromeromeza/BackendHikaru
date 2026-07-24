using Hikaru.Catalog.Domain.Model.Aggregates;
using Hikaru.Catalog.Domain.Model.Commands.Product;

namespace Hikaru.Catalog.Domain.Services.Commands;

public interface IProductCommandService
{
    Task<Product?> Handle(CreateProductCommand command);
    Task<bool> Handle(DeleteProductCommand command);
    Task<bool> Handle(UpdateProductCommand command, int productId);
    
}