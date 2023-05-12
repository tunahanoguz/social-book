using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Authors;
using SocialBook.Application.Interfaces.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public class AuthorReviewLikeService : IAuthorReviewLikeService
    {
        private readonly IAuthorReviewLikeReadRepository _authorReviewLikeReadRepository;
        private readonly IAuthorReviewLikeWriteRepository _authorReviewLikeWriteRepository;

        public AuthorReviewLikeService(IAuthorReviewLikeReadRepository authorReviewLikeReadRepository, IAuthorReviewLikeWriteRepository authorReviewLikeWriteRepository)
        {
            _authorReviewLikeReadRepository = authorReviewLikeReadRepository;
            _authorReviewLikeWriteRepository = authorReviewLikeWriteRepository;
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewLike>> GetAuthorReviewLikesByAuthorReviewAsync(Guid authorReviewId, PaginationFilter paginationFilter)
        {
            if (authorReviewId == Guid.Empty) { throw new ArgumentNullException(nameof(authorReviewId)); }

            return await _authorReviewLikeReadRepository.GetAuthorReviewLikesByAuthorReviewAsync(authorReviewId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorReviewLike>> GetAuthorReviewLikesByUserAsync(string userId, PaginationFilter paginationFilter)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReviewLikeReadRepository.GetAuthorReviewLikesByUserAsync(userId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<AuthorReviewLike> CreateAuthorReviewLikeAsync(AuthorReviewLike authorReviewLike)
        {
            if (authorReviewLike == null) { throw new ArgumentNullException(nameof(authorReviewLike)); }

            await _authorReviewLikeWriteRepository.AddAsync(authorReviewLike);
            await _authorReviewLikeWriteRepository.SaveAsync();

            return await _authorReviewLikeReadRepository.GetByIdAsync(authorReviewLike.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<AuthorReviewLike> UpdateAuthorReviewLikeAsync(AuthorReviewLike authorReviewLike)
        {
            if (authorReviewLike == null) { throw new ArgumentNullException(nameof(authorReviewLike)); }

            _authorReviewLikeWriteRepository.Update(authorReviewLike);
            await _authorReviewLikeWriteRepository.SaveAsync();

            return await _authorReviewLikeReadRepository.GetByIdAsync(authorReviewLike.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAuthorReviewLikeAsync(string id)
        {
            if (id == null) { throw new ArgumentNullException(nameof(id)); }

            await _authorReviewLikeWriteRepository.RemoveAsync(id);
            int affectedCount = await _authorReviewLikeWriteRepository.SaveAsync();

            return affectedCount > 0;
        }
    }
}
