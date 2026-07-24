using Hikaru.Catalog.Domain.Model.Aggregates;
using Hikaru.Shared.Domain.Repositories;

namespace Hikaru.Catalog.Domain.Repositories;

public interface IProductRepository: IBaseRepository<Product>
{
    Task<IEnumerable<Product>> FindBySubcategoryIdAsync(int subcategoryId);
}