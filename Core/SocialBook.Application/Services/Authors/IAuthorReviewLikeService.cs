using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorReviewLikeService
    {
        /// <summary>
        /// Get all author review likes for the author review with the given ID as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review likes for the author review with the given ID as a parameter
        /// </returns>
        Task<List<AuthorReviewLike>> GetAuthorReviewLikesByAuthorReviewAsync(Guid authorReviewId);

        /// <summary>
        /// Get all author review likes belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review likes belonging to the user whose ID is provided as a parameter
        /// </returns>
        Task<List<AuthorReviewLike>> GetAuthorReviewLikesByUserAsync(string userId);

        /// <summary>
        /// Create a new author review like
        /// </summary>
        /// <param name="authorReviewLike">The author review like entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review like was created successfully or not
        /// </returns>
        Task<bool> CreateAuthorReviewLikeAsync(AuthorReviewLike authorReviewLike);

        /// <summary>
        /// Update the author review like provided as a parameter
        /// </summary>
        /// <param name="authorReviewLike">The author review like entity</param>
        /// <returns>A boolean value indicating whether the author review like was updated successfully or not</returns>
        bool UpdateAuthorReviewLike(AuthorReviewLike authorReviewLike);

        /// <summary>
        /// Delete the author review like provided as a parameter
        /// </summary>
        /// <param name="authorReviewLike">The author review like entity</param>
        /// <returns>A boolean value indicating whether the author review like was deleted successfully or not</returns>
        bool DeleteAuthorReviewLike(AuthorReviewLike authorReviewLike);
    }
}
