using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
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
        public async Task<List<AuthorReview>> GetAuthorReviewsByRatingAsync(int rating)
        {
            if (rating < 0) { throw new ArgumentNullException(nameof(rating)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByRatingAsync(rating);
        }

        /// <inheritdoc />
        public async Task<List<AuthorReview>> GetAuthorReviewsByAuthorAsync(Guid authorId)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByAuthorAsync(authorId);
        }

        /// <inheritdoc />
        public async Task<List<AuthorReview>> GetAuthorReviewsByUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByUserAsync(userId);
        }

        /// <inheritdoc />
        public async Task<bool> CreateAuthorReviewAsync(AuthorReview authorReview)
        {
            if (authorReview == null) { throw new ArgumentNullException(nameof(authorReview)); }

            return await _authorReviewWriteRepository.AddAsync(authorReview);
        }

        /// <inheritdoc />
        public bool UpdateAuthorReview(AuthorReview authorReview)
        {
            if (authorReview == null) { throw new ArgumentNullException(nameof(authorReview)); }

            return _authorReviewWriteRepository.Update(authorReview);
        }

        /// <inheritdoc />
        public bool DeleteAuthorReview(AuthorReview authorReview)
        {
            if (authorReview == null) { throw new ArgumentNullException(nameof(authorReview)); }

            return _authorReviewWriteRepository.Remove(authorReview);
        }
    }
}
