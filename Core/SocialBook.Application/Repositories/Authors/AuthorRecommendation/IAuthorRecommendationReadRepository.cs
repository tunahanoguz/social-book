using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorRecommendationReadRepository : IReadRepository<AuthorRecommendation>
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
    }
}
