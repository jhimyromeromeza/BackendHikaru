using Hikaru.Catalog.Domain.Model.Commands.Product;
using Hikaru.Catalog.Interfaces.REST.Resources;

namespace Hikaru.Catalog.Interfaces.REST.Transform;

public static class CreateProductCommandFromResource
{
    public static CreateProductCommand ToCommandFromResource(CreateProductResource resource)
    {
        return new CreateProductCommand(
            resource.Name,
            resource.Description,
            resource.Brand,
            resource.ProductType,
            resource.Stock,
            resource.Price,
            resource.FactoryPrice,
            resource.Discount,
            resource.UrlThumbnails,
            resource.Variants,
            resource.Details,
            resource.Visibility
    );
} 
}