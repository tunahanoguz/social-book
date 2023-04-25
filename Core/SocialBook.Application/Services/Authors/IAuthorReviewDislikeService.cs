using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorReviewDislikeService
    {
        /// <summary>
        /// Get all author review dislikes for the author review with the given ID as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review dislikes for the author review with the given ID as a parameter
        /// </returns>
        Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByAuthorReviewAsync(Guid authorReviewId);

        /// <summary>
        /// Get all author review dislikes belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review dislikes belonging to the user whose ID is provided as a parameter
        /// </returns>
        Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByUserAsync(string userId);

        /// <summary>
        /// Create a new author review dislike
        /// </summary>
        /// <param name="authorReviewDislike">The author review dislike entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review dislike was created successfully or not
        /// </returns>
        Task<bool> CreateAuthorReviewDislikeAsync(AuthorReviewDislike authorReviewDislike);

        /// <summary>
        /// Update the author review dislike provided as a parameter
        /// </summary>
        /// <param name="authorReviewDislike">The author review dislike entity</param>
        /// <returns>A boolean value indicating whether the author review dislike was updated successfully or not</returns>
        bool UpdateAuthorReviewDislike(AuthorReviewDislike authorReviewDislike);

        /// <summary>
        /// Delete the author review dislike provided as a parameter
        /// </summary>
        /// <param name="authorReviewDislike">The author review dislike entity</param>
        /// <returns>A boolean value indicating whether the author review dislike was deleted successfully or not</returns>
        bool DeleteAuthorReviewDislike(AuthorReviewDislike authorReviewDislike);
    }
}
