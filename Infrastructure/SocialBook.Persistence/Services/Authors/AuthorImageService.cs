using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorImageService : IAuthorImageService
    {
        private readonly IAuthorImageReadRepository _authorImageReadRepository;
        private readonly IAuthorImageWriteRepository _authorImageWriteRepository;

        public AuthorImageService(IAuthorImageReadRepository authorImageReadRepository,
            IAuthorImageWriteRepository authorImageWriteRepository)
        {
            _authorImageReadRepository = authorImageReadRepository;
            _authorImageWriteRepository = authorImageWriteRepository;
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorImage>> GetAuthorImagesByFileExtensionAsync(string extension, PaginationFilter paginationFilter)
        {
            if (extension == null) { throw new ArgumentNullException(nameof(extension)); }

            return await _authorImageReadRepository.GetAuthorImagesByFileExtensionAsync(extension, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorImage>> GetAuthorImagesByAuthorAsync(Guid authorId, PaginationFilter paginationFilter)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorImageReadRepository.GetAuthorImagesByAuthorAsync(authorId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<bool> CreateAuthorImageAsync(AuthorImage authorImage)
        {
            if (authorImage == null) { throw new ArgumentNullException(nameof(authorImage)); }

            return await _authorImageWriteRepository.AddAsync(authorImage);
        }

        /// <inheritdoc />
        public bool UpdateAuthorImage(AuthorImage authorImage)
        {
            if (authorImage == null) { throw new ArgumentNullException(nameof(authorImage)); }

            return _authorImageWriteRepository.Update(authorImage);
        }

        /// <inheritdoc />
        public bool DeleteAuthorImage(AuthorImage authorImage)
        {
            if (authorImage == null) { throw new ArgumentNullException(nameof(authorImage)); }

            return _authorImageWriteRepository.Remove(authorImage);
        }
    }
}
