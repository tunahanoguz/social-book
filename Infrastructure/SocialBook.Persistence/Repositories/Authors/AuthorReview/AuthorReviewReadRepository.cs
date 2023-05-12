using Microsoft.EntityFrameworkCore;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Authors;
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
        public async Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByRatingAsync(int rating, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.Rating == rating, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByAuthorAsync(Guid authorId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.AuthorId == authorId, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByUserAsync(string userId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.UserId == userId, paginationFilter, false);
        }
    }
}
