using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorSubscriptionService : IAuthorSubscriptionService
    {
        private readonly IAuthorSubscriptionReadRepository _authorSubscriptionReadRepository;
        private readonly IAuthorSubscriptionWriteRepository _authorSubscriptionWriteRepository;

        public AuthorSubscriptionService(IAuthorSubscriptionReadRepository authorSubscriptionReadRepository,
            IAuthorSubscriptionWriteRepository authorSubscriptionWriteRepository)
        {
            _authorSubscriptionReadRepository = authorSubscriptionReadRepository;
            _authorSubscriptionWriteRepository = authorSubscriptionWriteRepository;
        }

        /// <summary>
        /// Get author subscriptions belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author subscriptions belonging to the author whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorSubscription>> GetAuthorSubscriptionsByAuthorAsync(Guid authorId)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorSubscriptionReadRepository.GetAuthorSubscriptionsByAuthorAsync(authorId);
        }

        /// <summary>
        /// Get author subscriptions belonging to the creator user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The creator user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author subscriptions belonging to the creator user whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorSubscription>> GetAuthorSubscriptionsByUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorSubscriptionReadRepository.GetAuthorSubscriptionsByUserAsync(userId);
        }

        /// <summary>
        /// Create a new author subscription
        /// </summary>
        /// <param name="authorSubscription">The author subscription entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author subscription was created successfully or not
        /// </returns>
        public async Task<bool> CreateAuthorSubscriptionAsync(AuthorSubscription authorSubscription)
        {
            if (authorSubscription == null) { throw new ArgumentNullException(nameof (authorSubscription)); }

            return await _authorSubscriptionWriteRepository.AddAsync(authorSubscription);
        }

        /// <summary>
        /// Update the author subscription provided as a parameter
        /// </summary>
        /// <param name="authorSubscription">The author subscription entity</param>
        /// <returns>A boolean value indicating whether the author subscription was updated successfully or not</returns>
        public bool UpdateAuthorSubscription(AuthorSubscription authorSubscription)
        {
            if (authorSubscription == null) { throw new ArgumentNullException(nameof(authorSubscription)); }

            return _authorSubscriptionWriteRepository.Update(authorSubscription);
        }

        /// <summary>
        /// Delete the author subscription provided as a parameter
        /// </summary>
        /// <param name="authorSubscription">The author subscription entity</param>
        /// <returns>A boolean value indicating whether the author subscription was deleted successfully or not</returns>
        public bool DeleteAuthorSubscription(AuthorSubscription authorSubscription)
        {
            if (authorSubscription == null) { throw new ArgumentNullException(nameof(authorSubscription)); }

            return _authorSubscriptionWriteRepository.Remove(authorSubscription);
        }
    }
}
