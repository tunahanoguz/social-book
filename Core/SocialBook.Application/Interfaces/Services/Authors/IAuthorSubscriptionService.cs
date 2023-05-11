using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Interfaces.Services.Authors
{
    public interface IAuthorSubscriptionService
    {
        /// <summary>
        /// Get author subscriptions belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author subscriptions belonging to the author whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorSubscription>> GetAuthorSubscriptionsByAuthorAsync(Guid authorId, PaginationFilter paginationFilter);

        /// <summary>
        /// Get author subscriptions belonging to the creator user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The creator user identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author subscriptions belonging to the creator user whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorSubscription>> GetAuthorSubscriptionsByUserAsync(string userId, PaginationFilter paginationFilter);

        /// <summary>
        /// Create a new author subscription
        /// </summary>
        /// <param name="authorSubscription">The author subscription entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author subscription was created successfully or not
        /// </returns>
        Task<AuthorSubscription> CreateAuthorSubscriptionAsync(AuthorSubscription authorSubscription);

        /// <summary>
        /// Update the author subscription provided as a parameter
        /// </summary>
        /// <param name="authorSubscription">The author subscription entity</param>
        /// <returns>A boolean value indicating whether the author subscription was updated successfully or not</returns>
        Task<AuthorSubscription> UpdateAuthorSubscriptionAsync(AuthorSubscription authorSubscription);

        /// <summary>
        /// Delete the author subscription provided as a parameter
        /// </summary>
        /// <param name="authorSubscriptionId">The author subscription identifier</param>
        /// <returns>A boolean value indicating whether the author subscription was deleted successfully or not</returns>
        Task<bool> DeleteAuthorSubscriptionAsync(string authorSubscriptionId);
    }
}
