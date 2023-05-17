using SocialBook.Application.DTOs.Common;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Application.Interfaces.Services.Books
{
    /// <summary>
    /// Represents service interface for books
    /// </summary>
    public interface IBookService
    {
        /// <summary>
        /// Get a single book with the identifier provided as a parameter
        /// </summary>
        /// <param name="id">The book identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the book with the identifier provided as a parameter
        /// </returns>
        Task<Book> GetBookById(string id);

        /// <summary>
        /// Get a single book with the ISBN provided as a parameter
        /// </summary>
        /// <param name="isbn">The ISBN value of book</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the book with the ISBN provided as a parameter
        /// </returns>
        Task<Book> GetBookByIsbn(string isbn);

        /// <summary>
        /// Search and get all books with the name provided as a parameter
        /// </summary>
        /// <param name="name">The book name</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the book with the name provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Book>> SearchBooksByName(string name);

        /// <summary>
        /// Get all books with the language provided as a parameter
        /// </summary>
        /// <param name="language">The book language</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all books with the language provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Book>> GetBooksByLanguage(string language);

        /// <summary>
        /// Get all books based on whether they are allowed for review or not
        /// </summary>
        /// <param name="isAllowed">The permission status</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all books based on whether they are allowed for review or not
        /// </returns>
        Task<PaginatedListDto<Book>> GetBooksByReviewPermissionStatus(bool isAllowed);

        /// <summary>
        /// Get all books based on whether they are allowed for review or not
        /// </summary>
        /// <param name="isAllowed">The permission status</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all books based on whether they are allowed for review or not
        /// </returns>
        Task<PaginatedListDto<Book>> GetBooksByRecommendationPermissionStatus(bool isAllowed);

        /// <summary>
        /// Get all books based on whether they are allowed for subscription or not
        /// </summary>
        /// <param name="isAllowed">The permission status</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all books based on whether they are allowed for subscription or not
        /// </returns>
        Task<PaginatedListDto<Book>> GetBooksBySubscriptionPermissionStatus(bool isAllowed);

        /// <summary>
        /// Get all books with the identifier provided as a parameter
        /// </summary>
        /// <param name="creatorUserId">The creator user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all books with the identifier provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Book>> GetBooksByCreatorUserId(string creatorUserId);
    }
}
