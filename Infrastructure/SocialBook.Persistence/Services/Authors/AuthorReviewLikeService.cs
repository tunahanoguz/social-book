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

        public async Task<List<AuthorReviewLike>> GetAuthorReviewLikesByAuthorReviewAsync(Guid authorReviewId)
        {
            if (authorReviewId == Guid.Empty) { throw new ArgumentNullException(nameof(authorReviewId)); }

            return await _authorReviewLikeReadRepository.GetAuthorReviewLikesByAuthorReviewAsync(authorReviewId);
        }

        public async Task<List<AuthorReviewLike>> GetAuthorReviewLikesByUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReviewLikeReadRepository.GetAuthorReviewLikesByUserAsync(userId);
        }

        public async Task<bool> CreateAuthorReviewLikeAsync(AuthorReviewLike authorReviewLike)
        {
            if (authorReviewLike == null) { throw new ArgumentNullException(nameof(authorReviewLike)); }

            return await _authorReviewLikeWriteRepository.AddAsync(authorReviewLike);
        }

        public bool UpdateAuthorReviewLike(AuthorReviewLike authorReviewLike)
        {
            if (authorReviewLike == null) { throw new ArgumentNullException(nameof(authorReviewLike)); }

            return _authorReviewLikeWriteRepository.Update(authorReviewLike);
        }

        public bool DeleteAuthorReviewLike(AuthorReviewLike authorReviewLike)
        {
            if (authorReviewLike == null) { throw new ArgumentNullException(nameof(authorReviewLike)); }

            return _authorReviewLikeWriteRepository.Remove(authorReviewLike);
        }
    }
}
