using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorImageService : IAuthorImageService
    {
        private readonly IAuthorImageReadRepository _authorImageReadRepository;
        private readonly IAuthorImageWriteRepository _authorImageWriteRepository;

        public AuthorImageService(IAuthorImageReadRepository authorImageReadRepository, IAuthorImageWriteRepository authorImageWriteRepository)
        {
            _authorImageReadRepository = authorImageReadRepository;
            _authorImageWriteRepository = authorImageWriteRepository;
        }

        /// <summary>
        /// Get all author images with the file extension provided as a parameter
        /// </summary>
        /// <param name="fileExtension">The file extension</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author images with the file extension provided as a parameter
        /// </returns>
        public async Task<List<AuthorImage>> GetAuthorImagesByFileExtensionAsync(string extension)
        {
            if (extension == null) { throw new ArgumentNullException(nameof(extension)); }

            return await _authorImageReadRepository.GetAuthorImagesByFileExtensionAsync(extension);
        }

        /// <summary>
        /// Get all author images belonging to the author whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorId">The author identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author images belonging to the author whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorImage>> GetAuthorImagesByAuthorAsync(Guid authorId)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorImageReadRepository.GetAuthorImagesByAuthorAsync(authorId);
        }

        /// <summary>
        /// Create a new author image
        /// </summary>
        /// <param name="authorImage">The author image entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author image was created successfully or not
        /// </returns>
        public async Task<bool> CreateAuthorImageAsync(AuthorImage authorImage)
        {
            if (authorImage == null) { throw new ArgumentNullException(nameof(authorImage)); }

            return await _authorImageWriteRepository.AddAsync(authorImage);
        }

        /// <summary>
        /// Update the author image provided as a parameter
        /// </summary>
        /// <param name="authorImage">The author image entity</param>
        /// <returns>A boolean value indicating whether the author image was updated successfully or not</returns>
        public bool UpdateAuthorImage(AuthorImage authorImage)
        {
            if (authorImage == null) { throw new ArgumentNullException(nameof(authorImage)); }

            return _authorImageWriteRepository.Update(authorImage);
        }

        /// <summary>
        /// Delete the author image provided as a parameter
        /// </summary>
        /// <param name="authorImage">The author image entity</param>
        /// <returns>A boolean value indicating whether the author image was deleted successfully or not</returns>
        public bool DeleteAuthorImage(AuthorImage authorImage)
        {
            if (authorImage == null) { throw new ArgumentNullException(nameof(authorImage)); }

            return _authorImageWriteRepository.Remove(authorImage);
        }
    }
}
