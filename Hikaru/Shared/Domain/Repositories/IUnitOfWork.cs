namespace Hikaru.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}