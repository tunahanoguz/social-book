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

        public async Task<List<AuthorReview>> GetAuthorReviewsByRatingAsync(int rating)
        {
            if (rating < 0) { throw new ArgumentNullException(nameof(rating)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByRatingAsync(rating);
        }

        public async Task<List<AuthorReview>> GetAuthorReviewsByAuthorAsync(Guid authorId)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByAuthorAsync(authorId);
        }

        public async Task<List<AuthorReview>> GetAuthorReviewsByUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorReviewReadRepository.GetAuthorReviewsByUserAsync(userId);
        }

        public async Task<bool> CreateAuthorReviewAsync(AuthorReview author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            return await _authorReviewWriteRepository.AddAsync(author);
        }

        public bool UpdateAuthorReview(AuthorReview author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            return _authorReviewWriteRepository.Update(author);
        }

        public bool DeleteAuthorReview(AuthorReview author)
        {
            if (author == null) { throw new ArgumentNullException(nameof(author)); }

            return _authorReviewWriteRepository.Remove(author);
        }
    }
}
