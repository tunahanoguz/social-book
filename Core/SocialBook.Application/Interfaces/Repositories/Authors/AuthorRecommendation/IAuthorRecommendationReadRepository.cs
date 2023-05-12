using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Interfaces.Repositories.Authors
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
        Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId, PaginationFilter paginationFilter);

        /// <summary>
        /// Get author recommendations belonging to the recommender user whose ID is provided as a parameter
        /// </summary>
        /// <param name="recommenderUserId">The recommender user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the recommender user whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId, PaginationFilter paginationFilter);

        /// <summary>
        /// Get author recommendations belonging to the recipient user whose ID is provided as a parameter
        /// </summary>
        /// <param name="recipientUserId">The recipient user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the recipient user whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId, PaginationFilter paginationFilter);
    }
}
