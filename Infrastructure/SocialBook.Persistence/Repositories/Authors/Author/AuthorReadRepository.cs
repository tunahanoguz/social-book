using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Authors
{
    public class AuthorReadRepository : ReadRepository<Author>, IAuthorReadRepository
    {
        public AuthorReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsByFirstNameAsync(string firstName, PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.FirstName == firstName, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsByLastNameAsync(string lastName, PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.LastName == lastName, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsByCountryOfBirthAsync(string country, PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.CountryOfBirth == country, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsByYearOfBirthAsync(int year, PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.DateOfBirth.Year == year, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsAllowedReviewAsync(PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.IsAllowedReview == true, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsNotAllowedReviewAsync(PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.IsAllowedReview == false, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsAllowedRecommendationAsync(PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.IsAllowedRecommendation == true, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsNotAllowedRecommendationAsync(PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.IsAllowedRecommendation == false, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsAllowedSubscriptionAsync(PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.IsAllowedSubscription == true, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsNotAllowedSubscriptionAsync(PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.IsAllowedSubscription == false, paginationFilter, false);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsByCreatorUserAsync(string userId, PaginationFilter paginationFilter)
        {
            return await GetWhere(author => author.CreatorUserId == userId, paginationFilter, false);
        }
    }
}
