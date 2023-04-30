using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorRecommendationReadRepository : ReadRepository<AuthorRecommendation>, IAuthorRecommendationReadRepository
    {
        public AuthorRecommendationReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.AuthorId == authorId, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.RecommenderUserId == recommenderUserId, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId, PaginationFilter paginationFilter)
        {
            return await GetWhere(a => a.RecipientUserId == recipientUserId, paginationFilter, false);
        }
    }
}
