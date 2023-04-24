using SocialBook.Domain.Entities.Common;

namespace SocialBook.Application.Repositories.Common
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Add new entity entry
        /// </summary>
        /// <param name="entity">Entity entry</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task<bool> AddAsync(T entity);

        /// <summary>
        /// Add new entity entries
        /// </summary>
        /// <param name="entity">Entity entries</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task<bool> AddRangeAsync(List<T> entities);

        /// <summary>
        /// Remove an entity entry
        /// </summary>
        /// <param name="entity">Entity entry</param>
        /// <returns>Whether the entity entry has been deleted or not</returns>
        bool Remove(T entity);

        /// <summary>
        /// Remove an entity entry
        /// </summary>
        /// <param name="entity">Entity entry</param>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task<bool> RemoveAsync(string id);

        /// <summary>
        /// Remove an entity entries
        /// </summary>
        /// <param name="entity">Entity entries</param>
        /// <returns>Whether the entity entries has been deleted or not</returns>
        bool RemoveRange(List<T> entities);

        /// <summary>
        /// Update an entity entry
        /// </summary>
        /// <param name="entity">Entity entry</param>
        /// <returns>Whether the entity entry has been updated or not</returns>
        bool Update(T entity);

        /// <summary>
        /// Save the write operation
        /// </summary>
        /// <returns>A task that represents the asynchronous operation</returns>
        Task<int> SaveAsync();
    }
}
