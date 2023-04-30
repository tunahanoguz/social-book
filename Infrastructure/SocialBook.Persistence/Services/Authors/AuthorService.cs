using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly IAuthorWriteRepository _authorWriteRepository;

        public AuthorService(IAuthorReadRepository authorReadRepository,
            IAuthorWriteRepository authorWriteRepository)
        {
            _authorReadRepository = authorReadRepository;
            _authorWriteRepository = authorWriteRepository;
        }

        /// <inheritdoc />
        public async Task<Author> GetAuthorById(string authorId)
        {
            if (authorId == null) { throw new ArgumentNullException(nameof(authorId)); };

            return await _authorReadRepository.GetByIdAsync(authorId, false);
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
        public async Task<bool> CreateAuthorAsync(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            await _authorWriteRepository.AddAsync(author);
            int affectedCount = await _authorWriteRepository.SaveAsync();

            return affectedCount > 0;
        }

        /// <inheritdoc />
        public async Task<bool> UpdateAuthorAsync(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            _authorWriteRepository.Update(author);
            int affectedCount = await _authorWriteRepository.SaveAsync();

            return affectedCount > 0;
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
