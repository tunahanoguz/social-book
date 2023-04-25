using Microsoft.EntityFrameworkCore;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorReviewReadRepository : ReadRepository<AuthorReview>, IAuthorReviewReadRepository
    {
        public AuthorReviewReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Get all author reviews matching the rating value provided as a parameter
        /// </summary>
        /// <param name="rating">The author review rating</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews matching the rating value provided as a parameter
        /// </returns>
        public async Task<List<AuthorReview>> GetAuthorReviewsByRatingAsync(int rating)
        {
            return await GetWhere(a => a.Rating == rating).ToListAsync();
        }

        /// <summary>
        /// Get author reviews belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews belonging to the author whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorReview>> GetAuthorReviewsByAuthorAsync(Guid authorId)
        {
            return await GetWhere(a => a.AuthorId == authorId).ToListAsync();
        }

        /// <summary>
        /// Get author reviews belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews belonging to the user whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorReview>> GetAuthorReviewsByUserAsync(string userId)
        {
            return await GetWhere(a => a.UserId == userId).ToListAsync();
        }
    }
}
