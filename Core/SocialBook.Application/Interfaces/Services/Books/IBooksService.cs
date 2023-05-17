using SocialBook.Application.DTOs.Common;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Application.Interfaces.Services.Books
{
    /// <summary>
    /// Represents service interface for books
    /// </summary>
    public interface IBooksService
    {
        #region Book

        /// <summary>
        /// Get a single book with the identifier provided as a parameter
        /// </summary>
        /// <param name="id">The book identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the book with the identifier provided as a parameter
        /// </returns>
        Task<Book> GetBookByIdAsync(string id);

        /// <summary>
        /// Get a single book with the ISBN provided as a parameter
        /// </summary>
        /// <param name="isbn">The ISBN value of book</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the book with the ISBN provided as a parameter
        /// </returns>
        Task<Book> GetBookByIsbnAsync(string isbn);

        /// <summary>
        /// Search and get all books with the name provided as a parameter
        /// </summary>
        /// <param name="name">The book name</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the book with the name provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Book>> SearchBooksByNameAsync(string name);

        /// <summary>
        /// Get all books with the language provided as a parameter
        /// </summary>
        /// <param name="language">The book language</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all books with the language provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Book>> GetBooksByLanguageAsync(string language);

        /// <summary>
        /// Get all books with the genre provided as a parameter
        /// </summary>
        /// <param name="genre">The book genre</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all books with the genre provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Book>> GetBooksByGenre(string genre);

        /// <summary>
        /// Get all books based on whether they are allowed for review or not
        /// </summary>
        /// <param name="isAllowed">The permission status</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all books based on whether they are allowed for review or not
        /// </returns>
        Task<PaginatedListDto<Book>> GetBooksByReviewPermissionStatusAsync(bool isAllowed);

        /// <summary>
        /// Get all books based on whether they are allowed for review or not
        /// </summary>
        /// <param name="isAllowed">The permission status</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all books based on whether they are allowed for review or not
        /// </returns>
        Task<PaginatedListDto<Book>> GetBooksByRecommendationPermissionStatusAsync(bool isAllowed);

        /// <summary>
        /// Get all books based on whether they are allowed for subscription or not
        /// </summary>
        /// <param name="isAllowed">The permission status</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all books based on whether they are allowed for subscription or not
        /// </returns>
        Task<PaginatedListDto<Book>> GetBooksBySubscriptionPermissionStatusAsync(bool isAllowed);

        /// <summary>
        /// Get all books with the identifier provided as a parameter
        /// </summary>
        /// <param name="creatorUserId">The creator user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all books with the identifier provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Book>> GetBooksByCreatorUserIdAsync(string creatorUserId);

        /// <summary>
        /// Create a new book
        /// </summary>
        /// <param name="book">The book entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created book
        /// </returns>
        Task<Book> CreateBookAsync(Book book);

        /// <summary>
        /// Update the book provided as a parameter
        /// </summary>
        /// <param name="book">The book entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the updated book
        /// </returns>
        Task<Book> UpdateBookAsync(Book book);

        /// <summary>
        /// Delete the book with the identifier provided as a parameter
        /// </summary>
        /// <param name="id">The book identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author was deleted successfully or not
        /// </returns>
        Task<bool> DeleteBookByIdAsync(string id);

        #endregion Book

        #region Book Genre

        /// <summary>
        /// Get all book genres of a book
        /// </summary>
        /// <param name="bookId">The book identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all book genres of a book
        /// </returns>
        Task<PaginatedListDto<BookGenre>> GetBookGenresByBookIdAsync(string bookId);

        /// <summary>
        /// Add a new genre to a book
        /// </summary>
        /// <param name="bookGenre">The book genre entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created book genre
        /// </returns>
        Task<BookGenre> CreateBookGenreAsync(BookGenre bookGenre);

        /// <summary>
        /// Delete a new genre to a book
        /// </summary>
        /// <param name="bookGenreId">The book genre identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created book genre
        /// </returns>
        Task<bool> DeleteBookGenreByIdAsync(string bookGenreId);

        #endregion Book Genre
    }
}
