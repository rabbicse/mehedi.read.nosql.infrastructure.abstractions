using Mehedi.Application.SharedKernel.Persistence;
using Mehedi.Core.SharedKernel;

namespace Mehedi.Read.Infrastructure.SharedKernel.Repositories;

/// <summary>
/// Base repository class for read-only operations.
/// Sources: https://github.com/jeangatto/ASP.NET-Core-Clean-Architecture-CQRS-Event-Sourcing/blob/main/src/Shop.Query/Abstractions/IReadOnlyRepository.cs
/// https://github.com/jeangatto/ASP.NET-Core-Clean-Architecture-CQRS-Event-Sourcing/blob/main/src/Shop.Query/Data/Repositories/BaseReadOnlyRepository.cs 
/// </summary>
/// <typeparam name="TQueryModel">The type of the query model.</typeparam>
/// <typeparam name="Tkey">The type of the key.</typeparam>
/// <remarks>
/// Initializes a new instance of the <see cref="BaseReadOnlyRepository{TQueryModel, Tkey}"/> class.
/// </remarks>
/// <param name="context">The read database context.</param>
public abstract class QueryRepository<TQueryModel, Tkey>(IReadDbContext context) : IQueryRepository<TQueryModel, Tkey>
    where TQueryModel : IQueryModel<Tkey>
    where Tkey : IEquatable<Tkey>
{
    /// <summary>
    /// Get all collections
    /// </summary>
    /// <returns></returns>
    public async Task<(long, IEnumerable<TQueryModel>)> GetAllCollectionAsync()
    {
        return await context.GetAllCollectionAsync<TQueryModel>();
    }

    /// <summary>
    /// Get by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<TQueryModel?> GetByIdAsync(Tkey id)
    {
        return await context.GetByIdAsync<TQueryModel, Tkey>(id);
    }

    /// <summary>
    /// Get collection with pagination
    /// </summary>
    /// <param name="pageNumber"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    public async Task<(long, IEnumerable<TQueryModel>)> GetCollectionAsync(int pageNumber = 1, int pageSize = 100)
    {
        return await context.GetCollectionAsync<TQueryModel>(pageNumber: pageNumber, pageSize: pageSize);
    }
}
