using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorSubscriptionService
    {
        /// <summary>
        /// Get author subscriptions belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author subscriptions belonging to the author whose ID is provided as a parameter
        /// </returns>
        Task<List<AuthorSubscription>> GetAuthorSubscriptionsByAuthorAsync(Guid authorId);

        /// <summary>
        /// Get author subscriptions belonging to the creator user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The creator user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author subscriptions belonging to the creator user whose ID is provided as a parameter
        /// </returns>
        Task<List<AuthorSubscription>> GetAuthorSubscriptionsByUserAsync(string userId);

        /// <summary>
        /// Create a new author subscription
        /// </summary>
        /// <param name="authorSubscription">The author subscription entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author subscription was created successfully or not
        /// </returns>
        Task<bool> CreateAuthorSubscriptionAsync(AuthorSubscription authorSubscription);

        /// <summary>
        /// Update the author subscription provided as a parameter
        /// </summary>
        /// <param name="authorSubscription">The author subscription entity</param>
        /// <returns>A boolean value indicating whether the author subscription was updated successfully or not</returns>
        bool UpdateAuthorSubscription(AuthorSubscription authorSubscription);

        /// <summary>
        /// Delete the author subscription provided as a parameter
        /// </summary>
        /// <param name="authorSubscription">The author subscription entity</param>
        /// <returns>A boolean value indicating whether the author subscription was deleted successfully or not</returns>
        bool DeleteAuthorSubscription(AuthorSubscription authorSubscription);
    }
}
