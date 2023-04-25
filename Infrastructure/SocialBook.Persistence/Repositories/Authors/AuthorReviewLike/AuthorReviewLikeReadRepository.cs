using Microsoft.EntityFrameworkCore;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorReviewLikeReadRepository : ReadRepository<AuthorReviewLike>, IAuthorReviewLikeReadRepository
    {
        public AuthorReviewLikeReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Get all author review likes for the author review with the given ID as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review likes for the author review with the given ID as a parameter
        /// </returns>
        public async Task<List<AuthorReviewLike>> GetAuthorReviewLikesByAuthorReviewAsync(Guid authorReviewId)
        {
            return await GetWhere(a => a.AuthorReviewId == authorReviewId).ToListAsync();
        }

        /// <summary>
        /// Get all author review likes belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review likes belonging to the user whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorReviewLike>> GetAuthorReviewLikesByUserAsync(string userId)
        {
            return await GetWhere(a => a.UserId == userId).ToListAsync();
        }
    }
}
