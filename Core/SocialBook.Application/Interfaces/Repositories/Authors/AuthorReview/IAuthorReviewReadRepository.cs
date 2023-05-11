using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Interfaces.Repositories.Authors
{
    public interface IAuthorReviewReadRepository : IReadRepository<AuthorReview>
    {
        /// <summary>
        /// Get all author reviews matching the rating value provided as a parameter
        /// </summary>
        /// <param name="rating">The author review rating</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews matching the rating value provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByRatingAsync(int rating, PaginationFilter paginationFilter);

        /// <summary>
        /// Get author reviews belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews belonging to the author whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByAuthorAsync(Guid authorId, PaginationFilter paginationFilter);

        /// <summary>
        /// Get author reviews belonging to the user whose ID is provided as a parameter
        /// </summary>
        /// <param name="userId">The user identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author reviews belonging to the user whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByUserAsync(string userId, PaginationFilter paginationFilter);
    }
}
