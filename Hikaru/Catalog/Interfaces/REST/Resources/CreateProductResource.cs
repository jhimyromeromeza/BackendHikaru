using System.Text.Json;

namespace Hikaru.Catalog.Interfaces.REST.Resources;

public record CreateProductResource(
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