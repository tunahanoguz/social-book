using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Interfaces.Repositories.Authors
{
    public interface IAuthorReviewImageReadRepository : IReadRepository<AuthorReviewImage>
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
        /// Get all author review images belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <param name="paginationFilter">The pagination filter</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review images belonging to the author whose ID is provided as a parameter
        /// </returns>
        Task<PaginatedListDto<AuthorReviewImage>> GetAuthorReviewImagesByAuthorReviewAsync(Guid authorReviewId, PaginationFilter paginationFilter);
    }
}
