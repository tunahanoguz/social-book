using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

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
        public async Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByAuthorReviewAsync(Guid authorReviewId)
        {
            if (authorReviewId == Guid.Empty) { throw new ArgumentException(nameof(authorReviewId)); }

            return await _authorReviewDislikeReadRepository.GetAuthorReviewDislikesByAuthorReviewAsync(authorReviewId);
        }

        /// <inheritdoc />
        public async Task<List<AuthorReviewDislike>> GetAuthorReviewDislikesByUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReviewDislikeReadRepository.GetAuthorReviewDislikesByUserAsync(userId);
        }

        /// <inheritdoc />
        public async Task<bool> CreateAuthorReviewDislikeAsync(AuthorReviewDislike authorReviewDislike)
        {
            if (authorReviewDislike == null) { throw new ArgumentNullException(nameof(authorReviewDislike)); }

            return await _authorReviewDislikeWriteRepository.AddAsync(authorReviewDislike);
        }

        /// <inheritdoc />
        public bool UpdateAuthorReviewDislike(AuthorReviewDislike authorReviewDislike)
        {
            if (authorReviewDislike == null) { throw new ArgumentNullException(nameof(authorReviewDislike)); }

            return _authorReviewDislikeWriteRepository.Update(authorReviewDislike);
        }

        /// <inheritdoc />
        public bool DeleteAuthorReviewDislike(AuthorReviewDislike authorReviewDislike)
        {
            if (authorReviewDislike == null) { throw new ArgumentNullException(nameof(authorReviewDislike)); }

            return _authorReviewDislikeWriteRepository.Remove(authorReviewDislike);
        }
    }
}
