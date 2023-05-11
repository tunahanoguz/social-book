using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Authors;
using SocialBook.Application.Interfaces.Services.Authors;
using SocialBook.Domain.Entities.Authors;
using SocialBook.Persistence.Repositories.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorReviewDislikeService : IAuthorReviewDislikeService
    {
        private readonly IAuthorReviewDislikeReadRepository _authorReviewDislikeReadRepository;
        private readonly IAuthorReviewDislikeWriteRepository _authorReviewDislikeWriteRepository;

        public AuthorReviewDislikeService(IAuthorReviewDislikeReadRepository authorReviewDislikeReadRepository,
            IAuthorReviewDislikeWriteRepository authorReviewDislikeWriteRepository)
        {
            _authorReviewDislikeReadRepository = authorReviewDislikeReadRepository;
            _authorReviewDislikeWriteRepository = authorReviewDislikeWriteRepository;
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewDislike>> GetAuthorReviewDislikesByAuthorReviewAsync(Guid authorReviewId, PaginationFilter paginationFilter)
        {
            if (authorReviewId == Guid.Empty) { throw new ArgumentException(nameof(authorReviewId)); }

            return await _authorReviewDislikeReadRepository.GetAuthorReviewDislikesByAuthorReviewAsync(authorReviewId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewDislike>> GetAuthorReviewDislikesByUserAsync(string userId, PaginationFilter paginationFilter)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReviewDislikeReadRepository.GetAuthorReviewDislikesByUserAsync(userId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<AuthorReviewDislike> CreateAuthorReviewDislikeAsync(AuthorReviewDislike authorReviewDislike)
        {
            if (authorReviewDislike == null) { throw new ArgumentNullException(nameof(authorReviewDislike)); }

            await _authorReviewDislikeWriteRepository.AddAsync(authorReviewDislike);
            await _authorReviewDislikeWriteRepository.SaveAsync();

            return await _authorReviewDislikeReadRepository.GetByIdAsync(authorReviewDislike.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<AuthorReviewDislike> UpdateAuthorReviewDislikeAsync(AuthorReviewDislike authorReviewDislike)
        {
            if (authorReviewDislike == null) { throw new ArgumentNullException(nameof(authorReviewDislike)); }

            _authorReviewDislikeWriteRepository.Update(authorReviewDislike);
            await _authorReviewDislikeWriteRepository.SaveAsync();

            return await _authorReviewDislikeReadRepository.GetByIdAsync(authorReviewDislike.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAuthorReviewDislikeAsync(string id)
        {
            if (id == null) { throw new ArgumentNullException(nameof(id)); }

            await _authorReviewDislikeWriteRepository.RemoveAsync(id);
            int affectedCount = await _authorReviewDislikeWriteRepository.SaveAsync();

            return affectedCount > 0;
        }
    }
}
