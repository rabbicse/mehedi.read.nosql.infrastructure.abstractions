﻿using Mehedi.Core.SharedKernel;
using System.Linq.Expressions;

namespace Mehedi.Read.NoSql.Infrastructure.Abstractions;

/// <summary>
/// Represents a contract for synchronizing query models with the database.
/// Source: https://github.com/jeangatto/ASP.NET-Core-Clean-Architecture-CQRS-Event-Sourcing/blob/main/src/Shop.Query/Abstractions/ISynchronizeDb.cs
/// </summary>
public interface ISynchronizeDb
{
    /// <summary>
    /// Upserts a query model into the database.
    /// </summary>
    /// <typeparam name="TQueryModel">The type of the query model.</typeparam>
    /// <param name="queryModel">The query model to upsert.</param>
    /// <param name="upsertFilter">The filter expression to determine the upsert condition.</param>
    /// <returns>A task representing the asynchronous upsert operation.</returns>
    Task UpsertAsync<TQueryModel>(TQueryModel queryModel, Expression<Func<TQueryModel, bool>> upsertFilter)
        where TQueryModel : IQueryModel;

    /// <summary>
    /// Deletes query models from the database that match the specified filter.
    /// </summary>
    /// <typeparam name="TQueryModel">The type of the query model.</typeparam>
    /// <param name="deleteFilter">The filter expression to determine which query models to delete.</param>
    /// <returns>A task representing the asynchronous delete operation.</returns>
    Task DeleteAsync<TQueryModel>(Expression<Func<TQueryModel, bool>> deleteFilter)
        where TQueryModel : IQueryModel;
}
