using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Repositories.Authors;
using SocialBook.Application.Interfaces.Services.Authors;
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
        public async Task<AuthorSubscription> CreateAuthorSubscriptionAsync(AuthorSubscription authorSubscription)
        {
            if (authorSubscription == null) { throw new ArgumentNullException(nameof(authorSubscription)); }

            await _authorSubscriptionWriteRepository.AddAsync(authorSubscription);
            await _authorSubscriptionWriteRepository.SaveAsync();

            return await _authorSubscriptionReadRepository.GetByIdAsync(authorSubscription.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<AuthorSubscription> UpdateAuthorSubscriptionAsync(AuthorSubscription authorSubscription)
        {
            if (authorSubscription == null) { throw new ArgumentNullException(nameof(authorSubscription)); }

            _authorSubscriptionWriteRepository.Update(authorSubscription);
            await _authorSubscriptionWriteRepository.SaveAsync();

            return await _authorSubscriptionReadRepository.GetByIdAsync(authorSubscription.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAuthorSubscriptionAsync(string id)
        {
            if (id == null) { throw new ArgumentNullException(nameof(id)); }

            await _authorSubscriptionWriteRepository.RemoveAsync(id);
            int affectedCount = await _authorSubscriptionWriteRepository.SaveAsync();

            return affectedCount > 0;
        }
    }
}
