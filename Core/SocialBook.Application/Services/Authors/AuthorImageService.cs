using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Authors;
using SocialBook.Application.Interfaces.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public class AuthorImageService : IAuthorImageService
    {
        private readonly IAuthorImageReadRepository _authorImageReadRepository;
        private readonly IAuthorImageWriteRepository _authorImageWriteRepository;
        private readonly IWebHostEnvironment _environment;

        public AuthorImageService(IAuthorImageReadRepository authorImageReadRepository,
            IAuthorImageWriteRepository authorImageWriteRepository,
            IWebHostEnvironment environment)
        {
            _authorImageReadRepository = authorImageReadRepository;
            _authorImageWriteRepository = authorImageWriteRepository;
            _environment = environment;
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorImage>> GetAuthorImagesByAuthorAsync(Guid authorId, PaginationFilter paginationFilter)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorImageReadRepository.GetAuthorImagesByAuthorAsync(authorId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<AuthorImage> CreateAuthorImageAsync(Guid authorId, IFormFile image)
        {
            if (authorId == Guid.Empty) { throw new ArgumentException(nameof(authorId)); }

            if (image == null || image.Length == 0) { throw new ArgumentNullException(nameof(image)); }

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
            var fileExtension = Path.GetExtension(image.FileName);
            var fileSize = image.Length;
            var filePath = Path.Combine(_environment.WebRootPath, "Uploads/AuthorImages", fileName);

            AuthorImage authorImage = new AuthorImage
            {
                FileName = fileName,
                FileExtension = fileExtension,
                FileSize = fileSize,
                AuthorId = authorId
            };

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            await _authorImageWriteRepository.AddAsync(authorImage);
            await _authorImageWriteRepository.SaveAsync();

            return await _authorImageReadRepository.GetByIdAsync(authorImage.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<AuthorImage> UpdateAuthorImageAsync(AuthorImage authorImage)
        {
            if (authorImage == null) { throw new ArgumentNullException(nameof(authorImage)); }

            _authorImageWriteRepository.Update(authorImage);
            await _authorImageWriteRepository.SaveAsync();

            return await _authorImageReadRepository.GetByIdAsync(authorImage.AuthorId.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAuthorImageAsync(string id)
        {
            if (id == null) { throw new ArgumentNullException(nameof(id)); }

            await _authorImageWriteRepository.RemoveAsync(id);
            int affectedCount = await _authorImageWriteRepository.SaveAsync();

            return affectedCount > 0;
        }
    }
}
