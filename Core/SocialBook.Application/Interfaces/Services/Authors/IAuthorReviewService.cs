using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Interfaces.Services.Authors
{
    public interface IAuthorReviewService
    {
        /// <summary>
        /// Get all author reviews matching the rating value provided as a parameter
        /// </summary>
        /// <param name="rating">The author review rating</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews matching the rating value provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByRatingAsync(int rating, PaginationFilter paginationFilter);

        /// <summary>
        /// Get author reviews belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews belonging to the author whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByAuthorAsync(Guid authorId, PaginationFilter paginationFilter);

        /// <summary>
        /// Get author reviews belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The user identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews belonging to the user whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByUserAsync(string userId, PaginationFilter paginationFilter);

        /// <summary>
        /// Create a new author review
        /// </summary>
        /// <param name="authorReview">The author review entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review was created successfully or not
        /// </returns>
        Task<AuthorReview> CreateAuthorReviewAsync(AuthorReview authorReview);

        /// <summary>
        /// Update the author review provided as a parameter
        /// </summary>
        /// <param name="authorReview">The author review entity</param>
        /// <returns>A boolean value indicating whether the author review was updated successfully or not</returns>
        Task<AuthorReview> UpdateAuthorReviewAsync(AuthorReview authorReview);

        /// <summary>
        /// Delete the author review provided as a parameter
        /// </summary>
        /// <param name="authorReview">The author review entity</param>
        /// <returns>A boolean value indicating whether the author review was deleted successfully or not</returns>
        Task<bool> DeleteAuthorReviewAsync(string id);
    }
}
