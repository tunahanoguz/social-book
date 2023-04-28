using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly IAuthorWriteRepository _authorWriteRepository;

        public AuthorService(IAuthorReadRepository authorReadRepository, IAuthorWriteRepository authorWriteRepository)
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
        public async Task<List<Author>> GetAuthorsByFirstNameAsync(string firstName)
        {
            if (firstName == null) { throw new ArgumentNullException(nameof(firstName)); }

            return await _authorReadRepository.GetAuthorsByFirstNameAsync(firstName);
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByLastNameAsync(string lastName)
        {
            if (lastName == null) { throw new ArgumentNullException(nameof(lastName)); }

            return await _authorReadRepository.GetAuthorsByLastNameAsync(lastName);
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByCountryOfBirthAsync(string country)
        {
            if (country == null) { throw new ArgumentNullException(nameof(country)); }

            return await _authorReadRepository.GetAuthorsByCountryOfBirthAsync(country);
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByYearOfBirthAsync(int year)
        {
            if (year < 0) { throw new ArgumentOutOfRangeException(nameof(year)); }

            return await _authorReadRepository.GetAuthorsByYearOfBirthAsync(year);
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsAllowedReviewAsync()
        {
            return await _authorReadRepository.GetAuthorsAllowedReviewAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsNotAllowedReviewAsync()
        {
            return await _authorReadRepository.GetAuthorsNotAllowedReviewAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsAllowedRecommendationAsync()
        {
            return await _authorReadRepository.GetAuthorsAllowedRecommendationAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsNotAllowedRecommendationAsync()
        {
            return await _authorReadRepository.GetAuthorsNotAllowedRecommendationAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsAllowedSubscriptionAsync()
        {
            return await _authorReadRepository.GetAuthorsAllowedSubscriptionAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsNotAllowedSubscriptionAsync()
        {
            return await _authorReadRepository.GetAuthorsNotAllowedSubscriptionAsync();
        }

        /// <inheritdoc />
        public async Task<List<Author>> GetAuthorsByCreatorUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReadRepository.GetAuthorsByCreatorUserAsync(userId);
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
