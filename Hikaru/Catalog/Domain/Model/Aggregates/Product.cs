using System.Text.Json;
using Hikaru.Catalog.Domain.Model.Commands.Product;

namespace Hikaru.Catalog.Domain.Model.Aggregates;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public string ProductType { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public decimal FactoryPrice { get; set; }
    public decimal Discount { get; set; }
    public List<string> UrlThumbnails { get; set; } = [];
    public JsonElement Variants { get; set; }
    public JsonElement Details { get; set; }
    public bool Visibility { get; set; }

    public ICollection<Subcategory> Subcategories { get; private set; } = [];

    protected Product() { }

    public Product(CreateProductCommand command)
    {
        this.Name = command.Name;
        this.Description = command.Description;
        this.Brand = command.Brand;
        this.ProductType = command.ProductType;
        this.Stock = command.Stock;
        this.Price = command.Price;
        this.FactoryPrice = command.FactoryPrice;
        this.Discount = command.Discount;
        this.UrlThumbnails = command.UrlThumbnails;
        this.Variants = command.Variants;
        this.Details = command.Details;
        this.Visibility = command.Visibility;
    }

    public void UpdateProduct(UpdateProductCommand command)
    {
        this.Name = command.Name;
        this.Description = command.Description;
        this.Brand = command.Brand;
        this.ProductType = command.ProductType;
        this.Stock = command.Stock;
        this.Price = command.Price;
        this.FactoryPrice = command.FactoryPrice;
        this.Discount = command.Discount;
        this.UrlThumbnails = command.UrlThumbnails;
        this.Variants = command.Variants;
        this.Details = command.Details;
        this.Visibility = command.Visibility;
    }    

}