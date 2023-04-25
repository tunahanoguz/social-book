using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Repositories.Authors
{
    public interface IAuthorImageReadRepository : IReadRepository<AuthorImage>
    {
        /// <summary>
        /// Get all author images with the file extension provided as a parameter
        /// </summary>
        /// <param name="fileExtension">The file extension</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author images with the file extension provided as a parameter
        /// </returns>
        Task<List<AuthorImage>> GetAuthorImagesByFileExtensionAsync(string fileExtension);

        /// <summary>
        /// Get all author images belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author images belonging to the author whose ID is provided as a parameter
        /// </returns>
        Task<List<AuthorImage>> GetAuthorImagesByAuthorAsync(Guid authorId);
    }
}
