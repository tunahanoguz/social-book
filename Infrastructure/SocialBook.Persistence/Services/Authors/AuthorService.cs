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

        public async Task<List<Author>> GetAuthorsByFirstNameAsync(string firstName)
        {
            if (firstName == null) { throw new ArgumentNullException(nameof(firstName)); }

            return await _authorReadRepository.GetAllAuthorsByFirstNameAsync(firstName);
        }

        public async Task<List<Author>> GetAuthorsByLastNameAsync(string lastName)
        {
            if (lastName == null) { throw new ArgumentNullException(nameof(lastName)); }

            return await _authorReadRepository.GetAllAuthorsByLastNameAsync(lastName);
        }

        public async Task<List<Author>> GetAuthorsByCountryOfBirthAsync(string country)
        {
            if (country == null) { throw new ArgumentNullException(nameof(country)); }

            return await _authorReadRepository.GetAllAuthorsByCountryOfBirthAsync(country);
        }

        public async Task<List<Author>> GetAuthorsByYearOfBirthAsync(int year)
        {
            if (year < 0) { throw new ArgumentOutOfRangeException(nameof(year)); }

            return await _authorReadRepository.GetAllAuthorsByYearOfBirthAsync(year);
        }

        public async Task<List<Author>> GetAuthorsAllowedReviewAsync()
        {
            return await _authorReadRepository.GetAllAuthorsAllowedReviewAsync();
        }

        public async Task<List<Author>> GetAuthorsNotAllowedReviewAsync()
        {
            return await _authorReadRepository.GetAllAuthorsNotAllowedReviewAsync();
        }

        public async Task<List<Author>> GetAuthorsAllowedRecommendationAsync()
        {
            return await _authorReadRepository.GetAllAuthorsAllowedRecommendationAsync();
        }

        public async Task<List<Author>> GetAuthorsNotAllowedRecommendationAsync()
        {
            return await _authorReadRepository.GetAllAuthorsNotAllowedRecommendationAsync();
        }

        public async Task<List<Author>> GetAuthorsAllowedSubscriptionAsync()
        {
            return await _authorReadRepository.GetAllAuthorsAllowedSubscriptionAsync();
        }

        public async Task<List<Author>> GetAuthorsNotAllowedSubscriptionAsync()
        {
            return await _authorReadRepository.GetAllAuthorsNotAllowedSubscriptionAsync();
        }

        public async Task<List<Author>> GetAuthorsByCreatorUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReadRepository.GetAllAuthorsByCreatorUserAsync(userId);
        }

        public async Task<bool> CreateAuthorAsync(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            return await _authorWriteRepository.AddAsync(author);
        }

        public bool UpdateAuthor(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            return _authorWriteRepository.Update(author);
        }

        public bool DeleteAuthor(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            return _authorWriteRepository.Remove(author);
        }
    }
}
