using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorReviewDislikeReadRepository : IReadRepository<AuthorReviewDislike>
    {
        /// <summary>
        /// Get all author review dislikes for the author review with the given ID as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review dislikes for the author review with the given ID as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReviewDislike>> GetAuthorReviewDislikesByAuthorReviewAsync(Guid authorReviewId, PaginationFilter paginationFilter);

        /// <summary>
        /// Get all author review dislikes belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review dislikes belonging to the user whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReviewDislike>> GetAuthorReviewDislikesByUserAsync(string userId, PaginationFilter paginationFilter);
    }
}
