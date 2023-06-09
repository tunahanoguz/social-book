﻿using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Domain.Entities.Common;
using System.Linq.Expressions;

namespace SocialBook.Application.Interfaces.Repositories.Common
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Get all entity entries
        /// </summary>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <param name="isTrackingEnabled">Whether to track entity state for changes</param>
        /// <returns>Entity entries</returns>
        Task<PaginatedListDto<T>> GetAll(PaginationFilter paginationFilter, bool isTrackingEnabled = true);

        /// <summary>
        /// Get all entity entries that meet the specified conditions
        /// </summary>
        /// <param name="expression">Conditions to filter entity entries</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <param name="isTrackingEnabled">Whether to track entity state for changes</param>
        /// <returns>Entity entries that meet the specified conditions</returns>
        Task<PaginatedListDto<T>> GetWhere(Expression<Func<T, bool>> expression, PaginationFilter paginationFilter, bool isTrackingEnabled = true);

        /// <summary>
        /// Get the first entity entry that meet the specified conditions
        /// </summary>
        /// <param name="expression">Conditions to filter entity entries</param>
        /// <param name="isTrackingEnabled">Whether to track entity state for changes</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the first entity entry that meet the specified conditions
        /// </returns>
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool isTrackingEnabled = true);

        /// <summary>
        /// Get an entity entry that have the ID value given as parameter
        /// </summary>
        /// <param name="id">Entity identifier</param>
        /// <param name="isTrackingEnabled">Whether to track entity state for changes</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains an entity entry that have the ID value given as parameter
        /// </returns>
        Task<T> GetByIdAsync(string id, bool isTrackingEnabled = true);
    }
}
