using Hikaru.Shared.Domain.Repositories;
using Hikaru.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace Hikaru.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork(AppDbContext appDbContext): IUnitOfWork
{
    public async Task CompleteAsync()
    {
        await appDbContext.SaveChangesAsync();
    }
}