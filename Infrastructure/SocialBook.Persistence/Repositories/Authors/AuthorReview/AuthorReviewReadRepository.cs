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

        /// <inheritdoc />
        public async Task<List<AuthorReview>> GetAuthorReviewsByRatingAsync(int rating)
        {
            return await GetWhere(a => a.Rating == rating).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<AuthorReview>> GetAuthorReviewsByAuthorAsync(Guid authorId)
        {
            return await GetWhere(a => a.AuthorId == authorId).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<AuthorReview>> GetAuthorReviewsByUserAsync(string userId)
        {
            return await GetWhere(a => a.UserId == userId).ToListAsync();
        }
    }
}
