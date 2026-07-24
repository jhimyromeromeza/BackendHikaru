using Hikaru.Catalog.Domain.Model.Aggregates;
using Hikaru.Catalog.Domain.Repositories;
using Hikaru.Shared.Infrastructure.Persistence.EFC.Configuration;
using Hikaru.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Hikaru.Catalog.Infrastructure.Persistence.EFC.Repositories;

public class ProductRepository(AppDbContext appDbContext): BaseRepository<Product>(appDbContext), IProductRepository
{
    
    public async Task<IEnumerable<Product>> FindBySubcategoryIdAsync(int subcategoryId)
    {
        return await Context.Set<Product>()
            .Where(p => p.Subcategories.Any(s => s.Id == subcategoryId))
            .ToListAsync();
    }
}