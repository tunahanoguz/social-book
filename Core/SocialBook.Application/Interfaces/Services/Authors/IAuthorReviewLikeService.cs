using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Interfaces.Services.Authors
{
    public interface IAuthorReviewLikeService
    {
        /// <summary>
        /// Get all author review likes for the author review with the given ID as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review likes for the author review with the given ID as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReviewLike>> GetAuthorReviewLikesByAuthorReviewAsync(Guid authorReviewId, PaginationFilter paginationFilter);

        /// <summary>
        /// Get all author review likes belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The author review identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review likes belonging to the user whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReviewLike>> GetAuthorReviewLikesByUserAsync(string userId, PaginationFilter paginationFilter);

        /// <summary>
        /// Create a new author review like
        /// </summary>
        /// <param name="authorReviewLike">The author review like entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review like was created successfully or not
        /// </returns>
        Task<AuthorReviewLike> CreateAuthorReviewLikeAsync(AuthorReviewLike authorReviewLike);

        /// <summary>
        /// Update the author review like provided as a parameter
        /// </summary>
        /// <param name="authorReviewLike">The author review like entity</param>
        /// <returns>A boolean value indicating whether the author review like was updated successfully or not</returns>
        Task<AuthorReviewLike> UpdateAuthorReviewLikeAsync(AuthorReviewLike authorReviewLike);

        /// <summary>
        /// Delete the author review like provided as a parameter
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>A boolean value indicating whether the author review like was deleted successfully or not</returns>
        Task<bool> DeleteAuthorReviewLikeAsync(string id);
    }
}
