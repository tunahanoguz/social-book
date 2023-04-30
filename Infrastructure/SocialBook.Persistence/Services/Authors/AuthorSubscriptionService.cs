using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
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

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorSubscription>> GetAuthorSubscriptionsByAuthorAsync(Guid authorId, PaginationFilter paginationFilter)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorSubscriptionReadRepository.GetAuthorSubscriptionsByAuthorAsync(authorId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorSubscription>> GetAuthorSubscriptionsByUserAsync(string userId, PaginationFilter paginationFilter)
        {
            if (userId == null) { throw new ArgumentNullException(nameof(userId)); }

            return await _authorSubscriptionReadRepository.GetAuthorSubscriptionsByUserAsync(userId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<bool> CreateAuthorSubscriptionAsync(AuthorSubscription authorSubscription)
        {
            if (authorSubscription == null) { throw new ArgumentNullException(nameof(authorSubscription)); }

            return await _authorSubscriptionWriteRepository.AddAsync(authorSubscription);
        }

        /// <inheritdoc />
        public bool UpdateAuthorSubscription(AuthorSubscription authorSubscription)
        {
            if (authorSubscription == null) { throw new ArgumentNullException(nameof(authorSubscription)); }

            return _authorSubscriptionWriteRepository.Update(authorSubscription);
        }

        /// <inheritdoc />
        public bool DeleteAuthorSubscription(AuthorSubscription authorSubscription)
        {
            if (authorSubscription == null) { throw new ArgumentNullException(nameof(authorSubscription)); }

            return _authorSubscriptionWriteRepository.Remove(authorSubscription);
        }
    }
}
