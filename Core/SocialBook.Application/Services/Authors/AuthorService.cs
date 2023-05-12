using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Authors;
using SocialBook.Application.Interfaces.Services.Authors;
using SocialBook.Application.Interfaces.Services.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public class AuthorService : IAuthorService
    {
        private readonly ICacheService _cacheService;
        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly IAuthorWriteRepository _authorWriteRepository;

        public AuthorService(ICacheService cacheService,
            IAuthorReadRepository authorReadRepository,
            IAuthorWriteRepository authorWriteRepository)
        {
            _cacheService = cacheService;
            _authorReadRepository = authorReadRepository;
            _authorWriteRepository = authorWriteRepository;
        }

        /// <inheritdoc />
        public async Task<Author> GetAuthorById(string authorId)
        {
            if (authorId == null) { throw new ArgumentNullException(nameof(authorId)); };

            var data = await _cacheService.GetAsync<Author>(authorId);

            if (data == null)
            {
                data = await _authorReadRepository.GetByIdAsync(authorId, false);
                await _cacheService.SetAsync(authorId, data);
            }

            return data;
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsByFirstNameAsync(string firstName, PaginationFilter paginationFilter)
        {
            if (firstName == null) { throw new ArgumentNullException(nameof(firstName)); }

            return await _authorReadRepository.GetAuthorsByFirstNameAsync(firstName, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsByLastNameAsync(string lastName, PaginationFilter paginationFilter)
        {
            if (lastName == null) { throw new ArgumentNullException(nameof(lastName)); }

            return await _authorReadRepository.GetAuthorsByLastNameAsync(lastName, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsByCountryOfBirthAsync(string country, PaginationFilter paginationFilter)
        {
            if (country == null) { throw new ArgumentNullException(nameof(country)); }

            return await _authorReadRepository.GetAuthorsByCountryOfBirthAsync(country, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsByYearOfBirthAsync(int year, PaginationFilter paginationFilter)
        {
            if (year < 0) { throw new ArgumentOutOfRangeException(nameof(year)); }

            return await _authorReadRepository.GetAuthorsByYearOfBirthAsync(year, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsAllowedReviewAsync(PaginationFilter paginationFilter)
        {
            return await _authorReadRepository.GetAuthorsAllowedReviewAsync(paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsNotAllowedReviewAsync(PaginationFilter paginationFilter)
        {
            return await _authorReadRepository.GetAuthorsNotAllowedReviewAsync(paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsAllowedRecommendationAsync(PaginationFilter paginationFilter)
        {
            return await _authorReadRepository.GetAuthorsAllowedRecommendationAsync(paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsNotAllowedRecommendationAsync(PaginationFilter paginationFilter)
        {
            return await _authorReadRepository.GetAuthorsNotAllowedRecommendationAsync(paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsAllowedSubscriptionAsync(PaginationFilter paginationFilter)
        {
            return await _authorReadRepository.GetAuthorsAllowedSubscriptionAsync(paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsNotAllowedSubscriptionAsync(PaginationFilter paginationFilter)
        {
            return await _authorReadRepository.GetAuthorsNotAllowedSubscriptionAsync(paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<Author>> GetAuthorsByCreatorUserAsync(string userId, PaginationFilter paginationFilter)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReadRepository.GetAuthorsByCreatorUserAsync(userId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<Author> CreateAuthorAsync(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            await _authorWriteRepository.AddAsync(author);
            await _authorWriteRepository.SaveAsync();

            return await _authorReadRepository.GetByIdAsync(author.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<Author> UpdateAuthorAsync(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            _authorWriteRepository.Update(author);
            await _authorWriteRepository.SaveAsync();

            return await _authorReadRepository.GetByIdAsync(author.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAuthorByIdAsync(string authorId)
        {
            if (authorId == null) { throw new ArgumentException(nameof(authorId)); }

            await _authorWriteRepository.RemoveAsync(authorId);
            int affectedCount = await _authorWriteRepository.SaveAsync();

            return affectedCount > 0;
        }
    }
}
