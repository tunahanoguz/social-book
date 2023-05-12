using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Authors;
using SocialBook.Application.Interfaces.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public class AuthorReviewService : IAuthorReviewService
    {
        private readonly IAuthorReviewReadRepository _authorReviewReadRepository;
        private readonly IAuthorReviewWriteRepository _authorReviewWriteRepository;

        public AuthorReviewService(IAuthorReviewReadRepository authorReviewReadRepository, IAuthorReviewWriteRepository authorReviewWriteRepository)
        {
            _authorReviewReadRepository = authorReviewReadRepository;
            _authorReviewWriteRepository = authorReviewWriteRepository;
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByRatingAsync(int rating, PaginationFilter paginationFilter)
        {
            if (rating < 0) { throw new ArgumentNullException(nameof(rating)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByRatingAsync(rating, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByAuthorAsync(Guid authorId, PaginationFilter paginationFilter)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByAuthorAsync(authorId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReview>> GetAuthorReviewsByUserAsync(string userId, PaginationFilter paginationFilter)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByUserAsync(userId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<AuthorReview> CreateAuthorReviewAsync(AuthorReview authorReview)
        {
            if (authorReview == null) { throw new ArgumentNullException(nameof(authorReview)); }

            await _authorReviewWriteRepository.AddAsync(authorReview);
            await _authorReviewWriteRepository.SaveAsync();

            return await _authorReviewReadRepository.GetByIdAsync(authorReview.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<AuthorReview> UpdateAuthorReviewAsync(AuthorReview authorReview)
        {
            if (authorReview == null) { throw new ArgumentNullException(nameof(authorReview)); }

            _authorReviewWriteRepository.Update(authorReview);
            await _authorReviewWriteRepository.SaveAsync();

            return await _authorReviewReadRepository.GetByIdAsync(authorReview.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAuthorReviewAsync(string id)
        {
            if (id == null) { throw new ArgumentNullException(nameof(id)); }

            await _authorReviewWriteRepository.RemoveAsync(id);
            int affectedCount = await _authorReviewWriteRepository.SaveAsync();

            return affectedCount > 0;
        }
    }
}
