using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorSubscriptionReadRepository : IReadRepository<AuthorSubscription>
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
    }
}
