using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorSubscriptionService : IAuthorSubscriptionService
    {
        private readonly IAuthorSubscriptionReadRepository _authorSubscriptionReadRepository;
        private readonly IAuthorSubscriptionWriteRepository _authorSubscriptionWriteRepository;

        public AuthorSubscriptionService(IAuthorSubscriptionReadRepository authorSubscriptionReadRepository,
            IAuthorSubscriptionWriteRepository authorSubscriptionWriteRepository)
        {
            _authorSubscriptionReadRepository = authorSubscriptionReadRepository;
            _authorSubscriptionWriteRepository = authorSubscriptionWriteRepository;
        }

        public async Task<List<AuthorSubscription>> GetAuthorSubscriptionsByAuthorAsync(Guid authorId)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorSubscriptionReadRepository.GetAuthorSubscriptionsByAuthorAsync(authorId);
        }

        public async Task<List<AuthorSubscription>> GetAuthorSubscriptionsByUserAsync(string userId)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorSubscriptionReadRepository.GetAuthorSubscriptionsByUserAsync(userId);
        }

        public async Task<bool> CreateAuthorSubscriptionAsync(AuthorSubscription authorSubscription)
        {
            if (authorSubscription == null) { throw new ArgumentNullException(nameof (authorSubscription)); }

            return await _authorSubscriptionWriteRepository.AddAsync(authorSubscription);
        }

        public bool UpdateAuthorSubscription(AuthorSubscription authorSubscription)
        {
            if (authorSubscription == null) { throw new ArgumentNullException(nameof(authorSubscription)); }

            return _authorSubscriptionWriteRepository.Update(authorSubscription);
        }

        public bool DeleteAuthorSubscription(AuthorSubscription authorSubscription)
        {
            if (authorSubscription == null) { throw new ArgumentNullException(nameof(authorSubscription)); }

            return _authorSubscriptionWriteRepository.Remove(authorSubscription);
        }
    }
}
