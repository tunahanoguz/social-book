using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
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

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewLike>> GetAuthorReviewLikesByAuthorReviewAsync(Guid authorReviewId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.AuthorReviewId == authorReviewId, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewLike>> GetAuthorReviewLikesByUserAsync(string userId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.UserId == userId, paginationFilter, false);
        }
    }
}
