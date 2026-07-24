using Hikaru.Catalog.Domain.Model.Commands.Product;
using Hikaru.Catalog.Interfaces.REST.Resources;

namespace Hikaru.Catalog.Interfaces.REST.Transform;

public static class UpdateProductCommandFromResource
{
    public static UpdateProductCommand ToCommandFromResource(UpdateProductResource resource)
    {
        return new UpdateProductCommand(
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