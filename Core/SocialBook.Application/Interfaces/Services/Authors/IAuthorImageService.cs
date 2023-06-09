﻿using Microsoft.AspNetCore.Http;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Interfaces.Services.Authors
{
    public interface IAuthorImageService
    {
        /// <summary>
        /// Get all author images belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author images belonging to the author whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorImage>> GetAuthorImagesByAuthorAsync(Guid authorId, PaginationFilter paginationFilter);

        /// <summary>
        /// Create a new author image
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <param name="image">The author image</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author image was created successfully or not
        /// </returns>
        Task<AuthorImage> CreateAuthorImageAsync(Guid authorId, IFormFile image);

        /// <summary>
        /// Update the author image provided as a parameter
        /// </summary>
        /// <param name="authorImage">The author image entity</param>
        /// <returns>A boolean value indicating whether the author image was updated successfully or not</returns>
        Task<AuthorImage> UpdateAuthorImageAsync(AuthorImage authorImage);

        /// <summary>
        /// Delete the author image provided as a parameter
        /// </summary>
        /// <param name="authorImage">The author image entity</param>
        /// <returns>A boolean value indicating whether the author image was deleted successfully or not</returns>
        Task<bool> DeleteAuthorImageAsync(string id);
    }
}
