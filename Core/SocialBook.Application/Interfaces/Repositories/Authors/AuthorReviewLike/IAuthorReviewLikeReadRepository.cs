﻿using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Interfaces.Repositories.Authors
{
    public interface IAuthorReviewLikeReadRepository : IReadRepository<AuthorReviewLike>
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
        /// <param name="userId">The user identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review likes belonging to the user whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReviewLike>> GetAuthorReviewLikesByUserAsync(string userId, PaginationFilter paginationFilter);
    }
}
