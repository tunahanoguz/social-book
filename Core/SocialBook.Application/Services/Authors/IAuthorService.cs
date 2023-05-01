using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
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
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors with the first name provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Author>> GetAuthorsByFirstNameAsync(string firstName, PaginationFilter paginationFilter);

        /// <summary>
        /// Get all authors with the last name provided as a parameter
        /// </summary>
        /// <param name="lastName">The last name of the author</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors with the last name provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Author>> GetAuthorsByLastNameAsync(string lastName, PaginationFilter paginationFilter);

        /// <summary>
        /// Get all authors born in the country provided as a parameter
        /// </summary>
        /// <param name="country">The country where the author was born</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors born in the country provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Author>> GetAuthorsByCountryOfBirthAsync(string country, PaginationFilter paginationFilter);

        /// <summary>
        /// Get all authors born in the year provided as a parameter
        /// </summary>
        /// <param name="year">The year where the author was born</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors born in the year provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Author>> GetAuthorsByYearOfBirthAsync(int year, PaginationFilter paginationFilter);

        /// <summary>
        /// Get all authors allowed to have reviews published about them
        /// </summary>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors allowed to have reviews published about them
        /// </returns>
        Task<PaginatedListDto<Author>> GetAuthorsAllowedReviewAsync(PaginationFilter paginationFilter);

        /// <summary>
        /// Get all authors not allowed to have reviews published about them
        /// </summary>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors not allowed to have reviews published about them
        /// </returns>
        Task<PaginatedListDto<Author>> GetAuthorsNotAllowedReviewAsync(PaginationFilter paginationFilter);

        /// <summary>
        /// Get all authors allowed to be recommended by users to other users
        /// </summary>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors allowed to be recommended by users to other users
        /// </returns>
        Task<PaginatedListDto<Author>> GetAuthorsAllowedRecommendationAsync(PaginationFilter paginationFilter);

        /// <summary>
        /// Get all authors not allowed to be recommended by users to other users
        /// </summary>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors not allowed to be recommended by users to other users
        /// </returns>
        Task<PaginatedListDto<Author>> GetAuthorsNotAllowedRecommendationAsync(PaginationFilter paginationFilter);

        /// <summary>
        /// Get all authors who are allowed to be subscribed to by users
        /// </summary>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors who are allowed to be subscribed to by users
        /// </returns>
        Task<PaginatedListDto<Author>> GetAuthorsAllowedSubscriptionAsync(PaginationFilter paginationFilter);

        /// <summary>
        /// Get all authors who are not allowed to be subscribed to by users
        /// </summary>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors who are not allowed to be subscribed to by users
        /// </returns>
        Task<PaginatedListDto<Author>> GetAuthorsNotAllowedSubscriptionAsync(PaginationFilter paginationFilter);

        /// <summary>
        /// Get all authors belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The creator user identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the authors belonging to the user whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Author>> GetAuthorsByCreatorUserAsync(string userId, PaginationFilter paginationFilter);

        /// <summary>
        /// Create a new author
        /// </summary>
        /// <param name="author">The author entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created author
        /// </returns>
        Task<Author> CreateAuthorAsync(Author author);

        /// <summary>
        /// Update the author provided as a parameter
        /// </summary>
        /// <param name="author">The author entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the updated author
        /// </returns>
        Task<Author> UpdateAuthorAsync(Author author);

        /// <summary>
        /// Delete the author provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>A boolean value indicating whether the author was deleted successfully or not</returns>
        Task<bool> DeleteAuthorByIdAsync(string authorId);
    }
}
