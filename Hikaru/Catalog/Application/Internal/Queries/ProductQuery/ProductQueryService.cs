using Hikaru.Catalog.Domain.Model.Aggregates;
using Hikaru.Catalog.Domain.Model.Queries;
using Hikaru.Catalog.Domain.Repositories;
using Hikaru.Catalog.Domain.Services.Queries;

namespace Hikaru.Catalog.Application.Internal.Queries.ProductQuery;

public class ProductQueryService(
    IProductRepository productRepository
    ): IProductQueryService
{

    public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery query)
    {
        return await productRepository.ListAsync();
    }

    public async Task<Product?> Handle(GetProductByIdQuery query)
    {
        return await productRepository.FindByIdAsync(query.ProductId);
    }

    public async Task<IEnumerable<Product>> Handle(GetProductsBySubcategoryQuery query)
    {
        //falta implementar
        return await productRepository.FindBySubcategoryIdAsync(query.SubcategoryId);
    }
}