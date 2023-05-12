using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Interfaces.Services.Authors
{
    public interface IAuthorRecommendationService
    {
        /// <summary>
        /// Get author recommendations belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the author whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId, PaginationFilter paginationFilter);

        /// <summary>
        /// Get author recommendations belonging to the recommender user whose ID is provided as a parameter
        /// </summary>
        /// <param name="recommenderUserId">The recommender user identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the recommender user whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId, PaginationFilter paginationFilter);

        /// <summary>
        /// Get author recommendations belonging to the recipient user whose ID is provided as a parameter
        /// </summary>
        /// <param name="recipientUserId">The recipient user identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author recommendations belonging to the recipient user whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId, PaginationFilter paginationFilter);

        /// <summary>
        /// Create a new author recommendation
        /// </summary>
        /// <param name="authorRecommendation">The author recommendation entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author recommendation was created successfully or not
        /// </returns>
        Task<AuthorRecommendation> CreateAuthorRecommendationAsync(AuthorRecommendation authorRecommendation);

        /// <summary>
        /// Update the author recommendation provided as a parameter
        /// </summary>
        /// <param name="authorRecommendation">The author recommendation entity</param>
        /// <returns>A boolean value indicating whether the author recommendation was updated successfully or not</returns>
        Task<AuthorRecommendation> UpdateRecommendationAuthorAsync(AuthorRecommendation authorRecommendation);

        /// <summary>
        /// Delete the author recommendation provided as a parameter
        /// </summary>
        /// <param name="authorRecommendation">The author recommendation entity</param>
        /// <returns>A boolean value indicating whether the author recommendation was deleted successfully or not</returns>
        Task<bool> DeleteRecommendationAuthorAsync(string id);
    }
}
