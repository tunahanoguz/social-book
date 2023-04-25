using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorReviewImageService : IAuthorReviewImageService
    {
        private readonly IAuthorReviewImageReadRepository _authorReviewImageReadRepository;
        private readonly IAuthorReviewImageWriteRepository _authorReviewImageWriteRepository;

        public AuthorReviewImageService(IAuthorReviewImageReadRepository authorReviewImageReadRepository,
            IAuthorReviewImageWriteRepository authorReviewImageWriteRepository)
        {
            _authorReviewImageReadRepository = authorReviewImageReadRepository;
            _authorReviewImageWriteRepository = authorReviewImageWriteRepository;
        }

        /// <summary>
        /// Get all author review images with the file extension provided as a parameter
        /// </summary>
        /// <param name="fileExtension">The file extension</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review images with the file extension provided as a parameter
        /// </returns>
        public async Task<List<AuthorReviewImage>> GetAuthorReviewImagesByFileExtensionAsync(string extenfileExtensionsion)
        {
            if (extension == null) { throw new ArgumentNullException(nameof(extension)); }

            return await _authorReviewImageReadRepository.GetAuthorReviewImagesByFileExtensionAsync(extension);
        }

        /// <summary>
        /// Get all author review images belonging to the author review whose ID is provided as a parameter
        /// </summary>
        /// <param name="authorReviewId">The author review identifier</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the author review images belonging to the author review whose ID is provided as a parameter
        /// </returns>
        public async Task<List<AuthorReviewImage>> GetAuthorReviewImagesByAuthorReviewAsync(Guid authorReviewId)
        {
            if (authorReviewId == Guid.Empty) { throw new ArgumentNullException(nameof(authorReviewId)); }

            return await _authorReviewImageReadRepository.GetAuthorReviewImagesByAuthorReviewAsync(authorReviewId);
        }

        /// <summary>
        /// Create a new author review image
        /// </summary>
        /// <param name="authorReviewImage">The author review image entity</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains a boolean value indicating whether the author review image was created successfully or not
        /// </returns>
        public async Task<bool> CreateAuthorReviewImageAsync(AuthorReviewImage authorReviewImage)
        {
            if (_authorReviewImageReadRepository == null) { throw new ArgumentNullException(nameof(authorReviewImage)); };

            return await _authorReviewImageWriteRepository.AddAsync(authorReviewImage);
        }

        /// <summary>
        /// Update the author review image provided as a parameter
        /// </summary>
        /// <param name="authorReviewImage">The author review image entity</param>
        /// <returns>A boolean value indicating whether the author review image was updated successfully or not</returns>
        public bool UpdateAuthorReviewImage(AuthorReviewImage authorReviewImage)
        {
            if (_authorReviewImageReadRepository == null) { throw new ArgumentNullException(nameof(authorReviewImage)); };

            return _authorReviewImageWriteRepository.Update(authorReviewImage);
        }

        /// <summary>
        /// Delete the author review image provided as a parameter
        /// </summary>
        /// <param name="authorReviewImage">The author review image entity</param>
        /// <returns>A boolean value indicating whether the author review image was deleted successfully or not</returns>
        public bool DeleteAuthorReviewImage(AuthorReviewImage authorReviewImage)
        {
            if (_authorReviewImageReadRepository == null) { throw new ArgumentNullException(nameof(authorReviewImage)); };

            return _authorReviewImageWriteRepository.Remove(authorReviewImage);
        }
    }
}
