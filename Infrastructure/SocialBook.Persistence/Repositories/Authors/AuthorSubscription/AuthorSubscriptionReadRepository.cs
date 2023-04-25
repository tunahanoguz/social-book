using Microsoft.EntityFrameworkCore;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorSubscriptionReadRepository : ReadRepository<AuthorSubscription>, IAuthorSubscriptionReadRepository
    {
        public AuthorSubscriptionReadRepository(SocialBookAPIDbContext context) : base(context)
        {
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
            return await GetWhere(a => a.AuthorId == authorId).ToListAsync();
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
            return await GetWhere(a => a.UserId == userId).ToListAsync();
        }
    }
}
