using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorRecommendationService
    {
        /// <summary>
        /// Get author recommendations belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the author whose ID is provided as a parameter
        /// </returns>
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId);

        /// <summary>
        /// Get author recommendations belonging to the recommender user whose ID is provided as a parameter
        /// </summary>
        /// <param name="recommenderUserId">The recommender user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the recommender user whose ID is provided as a parameter
        /// </returns>
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId);

        /// <summary>
        /// Get author recommendations belonging to the recipient user whose ID is provided as a parameter
        /// </summary>
        /// <param name="recipientUserId">The recipient user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the recipient user whose ID is provided as a parameter
        /// </returns>
        Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId);

        /// <summary>
        /// Create a new author recommendation
        /// </summary>
        /// <param name="authorRecommendation">The author recommendation entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author recommendation was created successfully or not
        /// </returns>
        Task<bool> CreateAuthorRecommendationAsync(AuthorRecommendation authorRecommendation);

        /// <summary>
        /// Update the author recommendation provided as a parameter
        /// </summary>
        /// <param name="authorRecommendation">The author recommendation entity</param>
        /// <returns>A boolean value indicating whether the author recommendation was updated successfully or not</returns>
        bool UpdateRecommendationAuthor(AuthorRecommendation authorRecommendation);

        /// <summary>
        /// Delete the author recommendation provided as a parameter
        /// </summary>
        /// <param name="authorRecommendation">The author recommendation entity</param>
        /// <returns>A boolean value indicating whether the author recommendation was deleted successfully or not</returns>
        bool DeleteRecommendationAuthor(AuthorRecommendation authorRecommendation);
    }
}
