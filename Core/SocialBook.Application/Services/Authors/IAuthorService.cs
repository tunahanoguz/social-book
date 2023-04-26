using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorService
    {
        /// <summary>
        /// Get the author with the identifier provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author with the identifier provided as a parameter
        /// </returns>
        Task<Author> GetAuthorById(string authorId);

        /// <summary>
        /// Get all authors with the first name provided as a parameter
        /// </summary>
        /// <param name="firstName">The first name of the author</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors with the first name provided as a parameter
        /// </returns>
        Task<List<Author>> GetAuthorsByFirstNameAsync(string firstName);

        /// <summary>
        /// Get all authors with the last name provided as a parameter
        /// </summary>
        /// <param name="lastName">The last name of the author</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors with the last name provided as a parameter
        /// </returns>
        Task<List<Author>> GetAuthorsByLastNameAsync(string lastName);

        /// <summary>
        /// Get all authors born in the country provided as a parameter
        /// </summary>
        /// <param name="country">The country where the author was born</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors born in the country provided as a parameter
        /// </returns>
        Task<List<Author>> GetAuthorsByCountryOfBirthAsync(string country);

        /// <summary>
        /// Get all authors born in the year provided as a parameter
        /// </summary>
        /// <param name="year">The year where the author was born</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors born in the year provided as a parameter
        /// </returns>
        Task<List<Author>> GetAuthorsByYearOfBirthAsync(int year);

        /// <summary>
        /// Get all authors allowed to have reviews published about them
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors allowed to have reviews published about them
        /// </returns>
        Task<List<Author>> GetAuthorsAllowedReviewAsync();

        /// <summary>
        /// Get all authors not allowed to have reviews published about them
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors not allowed to have reviews published about them
        /// </returns>
        Task<List<Author>> GetAuthorsNotAllowedReviewAsync();

        /// <summary>
        /// Get all authors allowed to be recommended by users to other users
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors allowed to be recommended by users to other users
        /// </returns>
        Task<List<Author>> GetAuthorsAllowedRecommendationAsync();

        /// <summary>
        /// Get all authors not allowed to be recommended by users to other users
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors not allowed to be recommended by users to other users
        /// </returns>
        Task<List<Author>> GetAuthorsNotAllowedRecommendationAsync();

        /// <summary>
        /// Get all authors who are allowed to be subscribed to by users
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors who are allowed to be subscribed to by users
        /// </returns>
        Task<List<Author>> GetAuthorsAllowedSubscriptionAsync();

        /// <summary>
        /// Get all authors who are not allowed to be subscribed to by users
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors who are not allowed to be subscribed to by users
        /// </returns>
        Task<List<Author>> GetAuthorsNotAllowedSubscriptionAsync();

        /// <summary>
        /// Get all authors belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The creator user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors belonging to the user whose ID is provided as a parameter
        /// </returns>
        Task<List<Author>> GetAuthorsByCreatorUserAsync(string userId);

        /// <summary>
        /// Create a new author
        /// </summary>
        /// <param name="author">The author entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author was created successfully or not
        /// </returns>
        Task<bool> CreateAuthorAsync(Author author);

        /// <summary>
        /// Update the author provided as a parameter
        /// </summary>
        /// <param name="author">The author entity</param>
        /// <returns>A boolean value indicating whether the author was updated successfully or not</returns>
        Task<bool> UpdateAuthorAsync(Author author);

        /// <summary>
        /// Delete the author provided as a parameter
        /// </summary>
        /// <param name="author">The author entity</param>
        /// <returns>A boolean value indicating whether the author was deleted successfully or not</returns>
        bool DeleteAuthor(Author author);
    }
}
