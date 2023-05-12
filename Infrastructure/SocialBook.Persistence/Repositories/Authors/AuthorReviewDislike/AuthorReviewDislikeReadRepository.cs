using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Authors;
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

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewDislike>> GetAuthorReviewDislikesByAuthorReviewAsync(Guid authorReviewId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.AuthorReviewId == authorReviewId, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewDislike>> GetAuthorReviewDislikesByUserAsync(string userId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.UserId == userId, paginationFilter, false);
        }
    }
}
