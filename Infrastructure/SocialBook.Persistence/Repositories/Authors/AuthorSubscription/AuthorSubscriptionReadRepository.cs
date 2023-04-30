using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
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
        public async Task<PaginatedListDto<AuthorSubscription>> GetAuthorSubscriptionsByAuthorAsync(Guid authorId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.AuthorId == authorId, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorSubscription>> GetAuthorSubscriptionsByUserAsync(string userId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.UserId == userId, paginationFilter, false);
        }
    }
}
