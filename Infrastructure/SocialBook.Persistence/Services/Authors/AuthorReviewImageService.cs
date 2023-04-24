using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorReviewImageService : IAuthorReviewImageService
    {
        private readonly IAuthorReviewImageReadRepository _authorReviewImageReadRepository;
        private readonly IAuthorReviewImageWriteRepository _authorReviewImageWriteRepository;

        public AuthorReviewImageService(IAuthorReviewImageReadRepository authorReviewImageReadRepository, IAuthorReviewImageWriteRepository authorReviewImageWriteRepository)
        {
            _authorReviewImageReadRepository = authorReviewImageReadRepository;
            _authorReviewImageWriteRepository = authorReviewImageWriteRepository;
        }

        public async Task<List<AuthorReviewImage>> GetAuthorReviewImagesByFileExtensionAsync(string extension)
        {
            if (extension == null) { throw new ArgumentNullException(nameof(extension)); }

            return await _authorReviewImageReadRepository.GetAuthorReviewImagesByFileExtensionAsync(extension);
        }

        public async Task<List<AuthorReviewImage>> GetAuthorReviewImagesByAuthorReviewAsync(Guid authorReviewId)
        {
            if (authorReviewId == Guid.Empty) { throw new ArgumentNullException(nameof(authorReviewId)); }

            return await _authorReviewImageReadRepository.GetAuthorReviewImagesByAuthorReviewAsync(authorReviewId);
        }

        public async Task<bool> CreateAuthorReviewImageAsync(AuthorReviewImage authorReviewImage)
        {
            if (_authorReviewImageReadRepository == null) { throw new ArgumentNullException(nameof(authorReviewImage)); };

            return await _authorReviewImageWriteRepository.AddAsync(authorReviewImage);
        }

        public bool UpdateAuthorReviewImage(AuthorReviewImage authorReviewImage)
        {
            if (_authorReviewImageReadRepository == null) { throw new ArgumentNullException(nameof(authorReviewImage)); };

            return _authorReviewImageWriteRepository.Update(authorReviewImage);
        }

        public bool DeleteAuthorReviewImage(AuthorReviewImage authorReviewImage)
        {
            if (_authorReviewImageReadRepository == null) { throw new ArgumentNullException(nameof(authorReviewImage)); };

            return _authorReviewImageWriteRepository.Remove(authorReviewImage);
        }
    }
}
