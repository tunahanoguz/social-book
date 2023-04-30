using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
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
        public async Task<bool> CreateAuthorReviewLikeAsync(AuthorReviewLike authorReviewLike)
        {
            if (authorReviewLike == null) { throw new ArgumentNullException(nameof(authorReviewLike)); }

            return await _authorReviewLikeWriteRepository.AddAsync(authorReviewLike);
        }

        /// <inheritdoc />
        public bool UpdateAuthorReviewLike(AuthorReviewLike authorReviewLike)
        {
            if (authorReviewLike == null) { throw new ArgumentNullException(nameof(authorReviewLike)); }

            return _authorReviewLikeWriteRepository.Update(authorReviewLike);
        }

        /// <inheritdoc />
        public bool DeleteAuthorReviewLike(AuthorReviewLike authorReviewLike)
        {
            if (authorReviewLike == null) { throw new ArgumentNullException(nameof(authorReviewLike)); }

            return _authorReviewLikeWriteRepository.Remove(authorReviewLike);
        }
    }
}
