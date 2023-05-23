using Microsoft.AspNetCore.Http;
using SocialBook.Application.DTOs.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialAuthor.Application.Interfaces.Services
{
    /// <summary>
    /// Represents service interface for authors
    /// </summary>
    public interface IAuthorsService
    {
        #region Author

        /// <summary>
        /// Get a single author with the identifier provided as a parameter
        /// </summary>
        /// <param name="id">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author with the identifier provided as a parameter
        /// </returns>
        Task<Author> GetAuthorByIdAsync(string id);

        /// <summary>
        /// Get a single author with the ISBN provided as a parameter
        /// </summary>
        /// <param name="isbn">The ISBN value of author</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author with the ISBN provided as a parameter
        /// </returns>
        Task<Author> GetAuthorByIsbnAsync(string isbn);

        /// <summary>
        /// Search and get all authors with the name provided as a parameter
        /// </summary>
        /// <param name="name">The author name</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author with the name provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Author>> SearchAuthorsByNameAsync(string name);

        /// <summary>
        /// Get all authors with the language provided as a parameter
        /// </summary>
        /// <param name="language">The author language</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all authors with the language provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Author>> GetAllAuthorsByLanguageAsync(string language);

        /// <summary>
        /// Get all authors with the genre provided as a parameter
        /// </summary>
        /// <param name="genre">The author genre</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all authors with the genre provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Author>> GetAllAuthorsByGenre(string genre);

        /// <summary>
        /// Get all authors based on whether they are allowed for review or not
        /// </summary>
        /// <param name="isAllowed">The permission status</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all authors based on whether they are allowed for review or not
        /// </returns>
        Task<PaginatedListDto<Author>> GetAllAuthorsByReviewPermissionStatusAsync(bool isAllowed);

        /// <summary>
        /// Get all authors based on whether they are allowed for review or not
        /// </summary>
        /// <param name="isAllowed">The permission status</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all authors based on whether they are allowed for review or not
        /// </returns>
        Task<PaginatedListDto<Author>> GetAllAuthorsByRecommendationPermissionStatusAsync(bool isAllowed);

        /// <summary>
        /// Get all authors based on whether they are allowed for subscription or not
        /// </summary>
        /// <param name="isAllowed">The permission status</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all authors based on whether they are allowed for subscription or not
        /// </returns>
        Task<PaginatedListDto<Author>> GetAllAuthorsBySubscriptionPermissionStatusAsync(bool isAllowed);

        /// <summary>
        /// Get all authors with the identifier provided as a parameter
        /// </summary>
        /// <param name="creatorUserId">The creator user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all authors with the identifier provided as a parameter
        /// </returns>
        Task<PaginatedListDto<Author>> GetAllAuthorsByCreatorUserIdAsync(string creatorUserId);

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
        /// Delete the author with the identifier provided as a parameter
        /// </summary>
        /// <param name="id">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author was deleted successfully or not
        /// </returns>
        Task<bool> DeleteAuthorByIdAsync(string id);

        #endregion Author

        #region Author Genre

        /// <summary>
        /// Get all author genres of a author
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author genres of a author
        /// </returns>
        Task<PaginatedListDto<AuthorGenre>> GetAllAuthorGenresByAuthorIdAsync(string authorId);

        /// <summary>
        /// Add a new genre to a author
        /// </summary>
        /// <param name="authorGenre">The author genre entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created author genre
        /// </returns>
        Task<AuthorGenre> CreateAuthorGenreAsync(AuthorGenre authorGenre);

        /// <summary>
        /// Delete a new genre to a author
        /// </summary>
        /// <param name="authorGenreId">The author genre identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author genre was deleted successfully or not
        /// </returns>
        Task<bool> DeleteAuthorGenreByIdAsync(string authorGenreId);

        #endregion Author Genre

        #region Author Image

        /// <summary>
        /// Get a single author image with the identifier provided as a parameter
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a single author image with the identifier provided as a parameter
        /// </returns>
        Task<AuthorImage> GetAuthorImageById(string id);

        /// <summary>
        /// Get all author images of a author
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author images of a author
        /// </returns>
        Task<PaginatedListDto<AuthorImage>> GetAllAuthorImagesByAuthorId(string authorId);

        /// <summary>
        /// Upload a new author image
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <param name="image">The form file represents the image</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the uploaded author image
        /// </returns>
        Task<AuthorImage> UploadAuthorImageAsync(string authorId, IFormFile image);

        /// <summary>
        /// Delete a author image
        /// </summary>
        /// <param name="id">The author image identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author image was deleted successfully or not
        /// </returns>
        Task<bool> DeleteAuthorImageByIdAsync(string id);

        #endregion Author Image

        #region Author Review

        /// <summary>
        /// Get a single author review with the identifier provided as a parameter
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a single author review with the identifier provided as a parameter
        /// </returns>
        Task<AuthorReview> GetAuthorReviewByIdAsync(string id);

        /// <summary>
        /// Get all author reviews
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author reviews with the identifier provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReview>> GetAllAuthorReviewsAsync();

        /// <summary>
        /// Get all author reviews of a author
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author reviews of a author
        /// </returns>
        Task<PaginatedListDto<AuthorReview>> GetAllAuthorReviewsByAuthorIdAsync(string authorId);

        /// <summary>
        /// Get all author reviews belongs to a user
        /// </summary>
        /// <param name="userId">The user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author reviews belongs to a user
        /// </returns>
        Task<PaginatedListDto<AuthorReview>> GetAllAuthorReviewsByUserIdAsync(string userId);

        /// <summary>
        /// Get all author reviews by rating
        /// </summary>
        /// <param name="rating">The review rating</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author reviews by rating
        /// </returns>
        Task<PaginatedListDto<AuthorReview>> GetAllAuthorReviewsByRatingAsync(int rating);

        /// <summary>
        /// Create a new author review
        /// </summary>
        /// <param name="authorReview">The author review entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created author review
        /// </returns>
        Task<AuthorReview> CreateAuthorReviewAsync(AuthorReview authorReview);

        /// <summary>
        /// Update a author review
        /// </summary>
        /// <param name="authorReview">The author review entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the updated author review
        /// </returns>
        Task<AuthorReview> UpdateAuthorReviewAsync(AuthorReview authorReview);

        /// <summary>
        /// Delete a author review
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review was deleted successfully or not
        /// </returns>
        Task<bool> DeleteAuthorReviewByIdAsync(string id);

        #endregion Author Review

        #region Author Review Image

        /// <summary>
        /// Get a single author review image with the identifier provided as a parameter
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a single author review image with the identifier provided as a parameter
        /// </returns>
        Task<AuthorImage> GetAuthorReviewImageById(string id);

        /// <summary>
        /// Get all author review images of a author
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author review images of a author
        /// </returns>
        Task<PaginatedListDto<AuthorImage>> GetAllAuthorReviewImagesByAuthorReviewId(string authorId);

        /// <summary>
        /// Upload a new author review image
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <param name="image">The form file represents the image</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the uploaded author review image
        /// </returns>
        Task<AuthorImage> UploadAuthorReviewImageAsync(string authorReviewId, IFormFile image);

        /// <summary>
        /// Delete a author review image
        /// </summary>
        /// <param name="id">The author review image identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review image was deleted successfully or not
        /// </returns>
        Task<bool> DeleteAuthorReviewImageByIdAsync(string id);

        #endregion Author Review Image

        #region Author Review Like

        /// <summary>
        /// Get all author review likes by author identifier
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author review likes by author identifier
        /// </returns>
        Task<PaginatedListDto<AuthorReviewLike>> GetAllAuthorReviewLikesByAuthorIdAsync(string authorId);

        /// <summary>
        /// Get all author review likes by user identifier
        /// </summary>
        /// <param name="userId">The user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author review likes by user identifier
        /// </returns>
        Task<PaginatedListDto<AuthorReviewLike>> GetAllAuthorReviewLikesByUserIdAsync(string userId);

        /// <summary>
        /// Create a new author review like
        /// </summary>
        /// <param name="authorReviewLike">The author review like entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created author review like
        /// </returns>
        Task<AuthorReviewLike> CreateAuthorReviewLikeAsync(AuthorReviewLike authorReviewLike);

        /// <summary>
        /// Delete a author review like
        /// </summary>
        /// <param name="id">The author review like identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review like was deleted successfully or not
        /// </returns>
        Task<bool> DeleteAuthorReviewLikeAsync(string id);

        #endregion Author Review Like

        #region Author Review Dislike

        /// <summary>
        /// Get all author review dislikes by author identifier
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author review dislikes by author identifier
        /// </returns>
        Task<PaginatedListDto<AuthorReviewDislike>> GetAllAuthorReviewDislikesByAuthorIdAsync(string authorId);

        /// <summary>
        /// Get all author review dislikes by user identifier
        /// </summary>
        /// <param name="userId">The user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author review dislikes by user identifier
        /// </returns>
        Task<PaginatedListDto<AuthorReviewDislike>> GetAllAuthorReviewDislikesByUserIdAsync(string userId);

        /// <summary>
        /// Create a new author review dislike
        /// </summary>
        /// <param name="authorReviewDislike">The author review dislike entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created author review dislike
        /// </returns>
        Task<AuthorReviewDislike> CreateAuthorReviewDislikeAsync(AuthorReviewDislike authorReviewDislike);

        /// <summary>
        /// Delete a author review dislike
        /// </summary>
        /// <param name="id">The author review dislike identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review dislike was deleted successfully or not
        /// </returns>
        Task<bool> DeleteAuthorReviewDislikeAsync(string id);

        #endregion Author Review Dislike

        #region Author Recommendation

        /// <summary>
        /// Get all author recommendations by author identifier
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author recommendations by author identifier
        /// </returns>
        Task<PaginatedListDto<AuthorRecommendation>> GetAllAuthorRecommendationsByAuthorIdAsync(string authorId);

        /// <summary>
        /// Get all author recommendations by author identifier
        /// </summary>
        /// <param name="userId">The user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author recommendations by author identifier
        /// </returns>
        Task<PaginatedListDto<AuthorRecommendation>> GetAllAuthorRecommendationsByUserIdAsync(string userId);

        /// <summary>
        /// Create a new author recommendation
        /// </summary>
        /// <param name="authorRecommendation">The author recommendation entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created author recommendation
        /// </returns>
        Task<AuthorRecommendation> CreateAuthorRecommendationAsync(AuthorRecommendation authorRecommendation);

        /// <summary>
        /// Delete a author recommendation by identifier
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author recommendation was deleted successfully or not
        /// </returns>
        Task<bool> DeleteAuthorRecommendationByIdAsync(string id);

        #endregion Author Recommendation

        #region Author Subscription

        /// <summary>
        /// Get all author subscriptions by author identifier
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author subscriptions by author identifier
        /// </returns>
        Task<PaginatedListDto<AuthorSubscription>> GetAllAuthorSubscriptionsByAuthorIdAsync(string authorId);

        /// <summary>
        /// Get all author subscriptions by author identifier
        /// </summary>
        /// <param name="userId">The user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains all author subscriptions by author identifier
        /// </returns>
        Task<PaginatedListDto<AuthorSubscription>> GetAllAuthorSubscriptionsByUserIdAsync(string userId);

        /// <summary>
        /// Create a new author subscription
        /// </summary>
        /// <param name="authorSubscription">The author subscription entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the created author subscription
        /// </returns>
        Task<AuthorSubscription> CreateAuthorSubscriptionAsync(AuthorSubscription authorSubscription);

        /// <summary>
        /// Delete a author subscription by identifier
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author subscription was deleted successfully or not
        /// </returns>
        Task<bool> DeleteAuthorSubscriptionByIdAsync(string id);

        #endregion Author Subscription
    }
}
