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

        /// <summary>
        /// Get the author with the identifier provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author with the identifier provided as a parameter
        /// </returns>
        public async Task<Author> GetAuthorById(string authorId)
        {
            if (authorId == null) { throw new ArgumentNullException(nameof(authorId)); };

            return await _authorReadRepository.GetByIdAsync(authorId, false);
        }

        /// <summary>
        /// Get all authors with the first name provided as a parameter
        /// </summary>
        /// <param name="firstName">The first name of the author</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors with the first name provided as a parameter
        /// </returns>
        public async Task<List<Author>> GetAuthorsByFirstNameAsync(string firstName)
        {
            if (firstName == null) { throw new ArgumentNullException(nameof(firstName)); }

            return await _authorReadRepository.GetAuthorsByFirstNameAsync(firstName);
        }

        /// <summary>
        /// Get all authors with the last name provided as a parameter
        /// </summary>
        /// <param name="lastName">The last name of the author</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors with the last name provided as a parameter
        /// </returns>
        public async Task<List<Author>> GetAuthorsByLastNameAsync(string lastName)
        {
            if (lastName == null) { throw new ArgumentNullException(nameof(lastName)); }

            return await _authorReadRepository.GetAuthorsByLastNameAsync(lastName);
        }

        /// <summary>
        /// Get all authors born in the country provided as a parameter
        /// </summary>
        /// <param name="country">The country where the author was born</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors born in the country provided as a parameter
        /// </returns>
        public async Task<List<Author>> GetAuthorsByCountryOfBirthAsync(string country)
        {
            if (country == null) { throw new ArgumentNullException(nameof(country)); }

            return await _authorReadRepository.GetAuthorsByCountryOfBirthAsync(country);
        }

        /// <summary>
        /// Get all authors born in the year provided as a parameter
        /// </summary>
        /// <param name="year">The year where the author was born</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors born in the year provided as a parameter
        /// </returns>
        public async Task<List<Author>> GetAuthorsByYearOfBirthAsync(int year)
        {
            if (year < 0) { throw new ArgumentOutOfRangeException(nameof(year)); }

            return await _authorReadRepository.GetAuthorsByYearOfBirthAsync(year);
        }

        /// <summary>
        /// Get all authors allowed to have reviews published about them
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors allowed to have reviews published about them
        /// </returns>
        public async Task<List<Author>> GetAuthorsAllowedReviewAsync()
        {
            return await _authorReadRepository.GetAuthorsAllowedReviewAsync();
        }

        /// <summary>
        /// Get all authors not allowed to have reviews published about them
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors not allowed to have reviews published about them
        /// </returns>
        public async Task<List<Author>> GetAuthorsNotAllowedReviewAsync()
        {
            return await _authorReadRepository.GetAuthorsNotAllowedReviewAsync();
        }

        /// <summary>
        /// Get all authors allowed to be recommended by users to other users
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors allowed to be recommended by users to other users
        /// </returns>
        public async Task<List<Author>> GetAuthorsAllowedRecommendationAsync()
        {
            return await _authorReadRepository.GetAuthorsAllowedRecommendationAsync();
        }

        /// <summary>
        /// Get all authors not allowed to be recommended by users to other users
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors not allowed to be recommended by users to other users
        /// </returns>
        public async Task<List<Author>> GetAuthorsNotAllowedRecommendationAsync()
        {
            return await _authorReadRepository.GetAuthorsNotAllowedRecommendationAsync();
        }

        /// <summary>
        /// Get all authors who are allowed to be subscribed to by users
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors who are allowed to be subscribed to by users
        /// </returns>
        public async Task<List<Author>> GetAuthorsAllowedSubscriptionAsync()
        {
            return await _authorReadRepository.GetAuthorsAllowedSubscriptionAsync();
        }

        /// <summary>
        /// Get all authors who are not allowed to be subscribed to by users
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors who are not allowed to be subscribed to by users
        /// </returns>
        public async Task<List<Author>> GetAuthorsNotAllowedSubscriptionAsync()
        {
            return await _authorReadRepository.GetAuthorsNotAllowedSubscriptionAsync();
        }

        /// <summary>
        /// Get all authors belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The creator user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors belonging to the user whose ID is provided as a parameter
        /// </returns>
        public async Task<List<Author>> GetAuthorsByCreatorUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReadRepository.GetAuthorsByCreatorUserAsync(userId);
        }

        /// <summary>
        /// Create a new author
        /// </summary>
        /// <param name="author">The author entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author was created successfully or not
        /// </returns>
        public async Task<bool> CreateAuthorAsync(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            await _authorWriteRepository.AddAsync(author);
            await _authorWriteRepository.SaveAsync();

            return true;
        }

        /// <summary>
        /// Update the author provided as a parameter
        /// </summary>
        /// <param name="author">The author entity</param>
        /// <returns>A boolean value indicating whether the author was updated successfully or not</returns>
        public async Task<bool> UpdateAuthorAsync(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            _authorWriteRepository.Update(author);
            int affectedEntities = await _authorWriteRepository.SaveAsync();

            return affectedEntities > 0;
        }

        /// <summary>
        /// Delete the author provided as a parameter
        /// </summary>
        /// <param name="author">The author entity</param>
        /// <returns>A boolean value indicating whether the author was deleted successfully or not</returns>
        public bool DeleteAuthor(Author author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            return _authorWriteRepository.Remove(author);
        }
    }
}
