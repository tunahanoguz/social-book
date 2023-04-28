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

        /// <inheritdoc />
        public async Task<List<AuthorSubscription>> GetAuthorSubscriptionsByAuthorAsync(Guid authorId)
        {
            return await GetWhere(a => a.AuthorId == authorId).ToListAsync();
        }

        /// <inheritdoc />
        public async Task<List<AuthorSubscription>> GetAuthorSubscriptionsByUserAsync(string userId)
        {
            return await GetWhere(a => a.UserId == userId).ToListAsync();
        }
    }
}
