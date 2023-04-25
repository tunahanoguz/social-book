using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorReviewImageReadRepository : IReadRepository<AuthorReviewImage>
    {
        /// <summary>
        /// Get all author review images with the file extension provided as a parameter
        /// </summary>
        /// <param name="fileExtension">The file extension</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review images with the file extension provided as a parameter
        /// </returns>
        Task<List<AuthorReviewImage>> GetAuthorReviewImagesByFileExtensionAsync(string fileExtension);

        /// <summary>
        /// Get all author review images belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review images belonging to the author whose ID is provided as a parameter
        /// </returns>
        Task<List<AuthorReviewImage>> GetAuthorReviewImagesByAuthorReviewAsync(Guid authorReviewId);
    }
}
