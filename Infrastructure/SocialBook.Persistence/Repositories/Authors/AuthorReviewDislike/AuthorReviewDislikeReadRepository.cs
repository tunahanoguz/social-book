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

        public async Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByAuthorReviewAsync(Guid authorReviewId)
        {
            return await GetWhere(a => a.AuthorReviewId == authorReviewId).ToListAsync();
        }

        public async Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByUserAsync(string userId)
        {
            return await GetWhere(a => a.UserId == userId).ToListAsync();
        }
    }
}
