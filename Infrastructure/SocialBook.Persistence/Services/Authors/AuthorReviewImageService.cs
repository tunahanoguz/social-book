using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Authors;
using SocialBook.Application.Interfaces.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorReviewImageService : IAuthorReviewImageService
    {
        private readonly IAuthorReviewImageReadRepository _authorReviewImageReadRepository;
        private readonly IAuthorReviewImageWriteRepository _authorReviewImageWriteRepository;
        private readonly IWebHostEnvironment _environment;

        public AuthorReviewImageService(IAuthorReviewImageReadRepository authorReviewImageReadRepository,
            IAuthorReviewImageWriteRepository authorReviewImageWriteRepository,
            IWebHostEnvironment environment)
        {
            _authorReviewImageReadRepository = authorReviewImageReadRepository;
            _authorReviewImageWriteRepository = authorReviewImageWriteRepository;
            _environment = environment;
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewImage>> GetAuthorReviewImagesByFileExtensionAsync(string fileExtension, PaginationFilter paginationFilter)
        {
            if (fileExtension == null) { throw new ArgumentNullException(nameof(fileExtension)); }

            return await _authorReviewImageReadRepository.GetAuthorReviewImagesByFileExtensionAsync(fileExtension, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewImage>> GetAuthorReviewImagesByAuthorReviewAsync(Guid authorReviewId, PaginationFilter paginationFilter)
        {
            if (authorReviewId == Guid.Empty) { throw new ArgumentNullException(nameof(authorReviewId)); }

            return await _authorReviewImageReadRepository.GetAuthorReviewImagesByAuthorReviewAsync(authorReviewId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<AuthorReviewImage> CreateAuthorReviewImageAsync(Guid authorReviewId, IFormFile image)
        {
            if (authorReviewId == Guid.Empty) { throw new ArgumentException(nameof(authorReviewId)); }

            if (image == null || image.Length == 0) { throw new ArgumentNullException(nameof(image)); }

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
            var fileExtension = Path.GetExtension(image.FileName);
            var fileSize = image.Length;
            var filePath = Path.Combine(_environment.WebRootPath, "Uploads/AuthorReviewImages", fileName);

            AuthorReviewImage authorReviewImage = new AuthorReviewImage
            {
                FileName = fileName,
                FileExtension = fileExtension,
                FileSize = fileSize,
                AuthorReviewId = authorReviewId
            };

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            await _authorReviewImageWriteRepository.AddAsync(authorReviewImage);
            await _authorReviewImageWriteRepository.SaveAsync();

            return await _authorReviewImageReadRepository.GetByIdAsync(authorReviewImage.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAuthorReviewImageAsync(string id)
        {
            if (id == null) { throw new ArgumentNullException(nameof(id)); };

            await _authorReviewImageWriteRepository.RemoveAsync(id);
            int affectedCount = await _authorReviewImageWriteRepository.SaveAsync();

            return affectedCount > 0;
        }
    }
}
