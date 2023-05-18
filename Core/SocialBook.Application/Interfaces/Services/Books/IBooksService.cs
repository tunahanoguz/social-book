using Microsoft.AspNetCore.Http;
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
        /// The task result contains a boolean value indicating whether the book was deleted successfully or not
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
        /// The task result contains a boolean value indicating whether the book genre was deleted successfully or not
        /// </returns>
        Task<bool> DeleteBookGenreByIdAsync(string bookGenreId);

        #endregion Book Genre

        #region Book Image

        /// <summary>
        /// Get a single book image with the identifier provided as a parameter
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a single book image with the identifier provided as a parameter
        /// </returns>
        Task<BookImage> GetBookImageById(string id);

        /// <summary>
        /// Get all book images of a book
        /// </summary>
        /// <param name="bookId">The book identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all book images of a book
        /// </returns>
        Task<PaginatedListDto<BookImage>> GetBookImagesByBookId(string bookId);

        /// <summary>
        /// Upload a new book image
        /// </summary>
        /// <param name="bookId">The book identifier</param>
        /// <param name="image">The form file represents the image</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the uploaded book image
        /// </returns>
        Task<BookImage> UploadBookImageAsync(string bookId, IFormFile image);

        /// <summary>
        /// Delete a book image
        /// </summary>
        /// <param name="id">The book image identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the book image was deleted successfully or not
        /// </returns>
        Task<bool> DeleteBookImageByIdAsync(string id);

        #endregion Book Image

        #region Book Review

        /// <summary>
        /// Get a single book review with the identifier provided as a parameter
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a single book review with the identifier provided as a parameter
        /// </returns>
        Task<BookReview> GetBookReviewByIdAsync(string id);

        /// <summary>
        /// Get all book reviews
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all book reviews with the identifier provided as a parameter
        /// </returns>
        Task<PaginatedListDto<BookReview>> GetAllBookReviewsAsync();

        /// <summary>
        /// Get all book reviews of a book
        /// </summary>
        /// <param name="bookId">The book identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all book reviews of a book
        /// </returns>
        Task<PaginatedListDto<BookReview>> GetAllBookReviewsByBookIdAsync(string bookId);

        /// <summary>
        /// Get all book reviews belongs to a user
        /// </summary>
        /// <param name="userId">The user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all book reviews belongs to a user
        /// </returns>
        Task<PaginatedListDto<BookReview>> GetAllBookReviewsByUserIdAsync(string userId);

        /// <summary>
        /// Get all book reviews by rating
        /// </summary>
        /// <param name="rating">The review rating</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all book reviews by rating
        /// </returns>
        Task<PaginatedListDto<BookReview>> GetAllBookReviewsByRatingAsync(int rating);

        /// <summary>
        /// Create a new book review
        /// </summary>
        /// <param name="bookReview">The book review entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created book review
        /// </returns>
        Task<BookReview> CreateBookReviewAsync(BookReview bookReview);

        /// <summary>
        /// Update a book review
        /// </summary>
        /// <param name="bookReview">The book review entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the updated book review
        /// </returns>
        Task<BookReview> UpdateBookReviewAsync(BookReview bookReview);

        /// <summary>
        /// Delete a book review
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the book review was deleted successfully or not
        /// </returns>
        Task<bool> DeleteBookReviewByIdAsync(string id);

        #endregion Book Review

        #region Book Review Image

        /// <summary>
        /// Get a single book review image with the identifier provided as a parameter
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a single book review image with the identifier provided as a parameter
        /// </returns>
        Task<BookImage> GetBookReviewImageById(string id);

        /// <summary>
        /// Get all book review images of a book
        /// </summary>
        /// <param name="bookId">The book identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all book review images of a book
        /// </returns>
        Task<PaginatedListDto<BookImage>> GetBookReviewImagesByBookReviewId(string bookId);

        /// <summary>
        /// Upload a new book review image
        /// </summary>
        /// <param name="bookReviewId">The book review identifier</param>
        /// <param name="image">The form file represents the image</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the uploaded book review image
        /// </returns>
        Task<BookImage> UploadBookReviewImageAsync(string bookReviewId, IFormFile image);

        /// <summary>
        /// Delete a book review image
        /// </summary>
        /// <param name="id">The book review image identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the book review image was deleted successfully or not
        /// </returns>
        Task<bool> DeleteBookReviewImageByIdAsync(string id);

        #endregion Book Review Image

        #region Book Review Like

        /// <summary>
        /// Get all book review likes by book identifier
        /// </summary>
        /// <param name="bookId">The book identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all book review likes by book identifier
        /// </returns>
        Task<PaginatedListDto<BookReviewLike>> GetAllBookReviewLikesByBookIdAsync(string bookId);

        /// <summary>
        /// Get all book review likes by user identifier
        /// </summary>
        /// <param name="userId">The user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all book review likes by user identifier
        /// </returns>
        Task<PaginatedListDto<BookReviewLike>> GetAllBookReviewLikesByUserIdAsync(string userId);

        /// <summary>
        /// Create a new book review like
        /// </summary>
        /// <param name="bookReviewLike">The book review like entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created book review like
        /// </returns>
        Task<BookReviewLike> CreateBookReviewLikeAsync(BookReviewLike bookReviewLike);

        /// <summary>
        /// Delete a book review like
        /// </summary>
        /// <param name="id">The book review like identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the book review like was deleted successfully or not
        /// </returns>
        Task<bool> DeleteBookReviewLikeAsync(string id);

        #endregion Book Review Like
    }
}
