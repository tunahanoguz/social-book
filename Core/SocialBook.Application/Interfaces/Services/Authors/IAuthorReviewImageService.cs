using Microsoft.AspNetCore.Http;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Interfaces.Services.Authors
{
    public interface IAuthorReviewImageService
    {
        /// <summary>
        /// Get all author review images with the file extension provided as a parameter
        /// </summary>
        /// <param name="fileExtension">The file extension</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review images with the file extension provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReviewImage>> GetAuthorReviewImagesByFileExtensionAsync(string fileExtension, PaginationFilter paginationFilter);

        /// <summary>
        /// Get all author review images belonging to the author review whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review images belonging to the author review whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReviewImage>> GetAuthorReviewImagesByAuthorReviewAsync(Guid authorReviewId, PaginationFilter paginationFilter);

        /// <summary>
        /// Create a new author review image
        /// </summary>
        /// <param name="authorReviewImage">The author review image entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review image was created successfully or not
        /// </returns>
        Task<AuthorReviewImage> CreateAuthorReviewImageAsync(Guid authorReviewId, IFormFile image);

        /// <summary>
        /// Delete the author review image provided as a parameter
        /// </summary>
        /// <param name="authorReviewImage">The author review image entity</param>
        /// <returns>A boolean value indicating whether the author review image was deleted successfully or not</returns>
        Task<bool> DeleteAuthorReviewImageAsync(string id);
    }
}
