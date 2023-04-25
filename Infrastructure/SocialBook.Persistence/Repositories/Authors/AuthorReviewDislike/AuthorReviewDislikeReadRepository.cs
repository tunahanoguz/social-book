using Microsoft.EntityFrameworkCore;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorReviewDislikeReadRepository : ReadRepository<AuthorReviewDislike>, IAuthorReviewDislikeReadRepository
    {
        public AuthorReviewDislikeReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Get all author review dislikes for the author review with the given ID as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review dislikes for the author review with the given ID as a parameter
        /// </returns>
        public async Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByAuthorReviewAsync(Guid authorReviewId)
        {
            return await GetWhere(a => a.AuthorReviewId == authorReviewId).ToListAsync();
        }

        /// <summary>
        /// Get all author review dislikes belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review dislikes belonging to the user whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByUserAsync(string userId)
        {
            return await GetWhere(a => a.UserId == userId).ToListAsync();
        }
    }
}
