using System.Text.Json;

namespace Hikaru.Catalog.Domain.Model.Commands.Product;

public record CreateProductCommand(
    string Name,
    string Description, 
    string Brand,
    string ProductType, 
    int Stock ,
    decimal Price ,
    decimal FactoryPrice,
    decimal Discount,
    List<string> UrlThumbnails ,
    JsonElement Variants,
    JsonElement Details ,
    bool Visibility
    );