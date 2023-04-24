using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Services.Authors
{
    public interface IAuthorSubscriptionService
    {
        Task<List<AuthorSubscription>> GetAuthorSubscriptionsByAuthorAsync(Guid authorId);
        Task<List<AuthorSubscription>> GetAuthorSubscriptionsByUserAsync(string userId);
        Task<bool> CreateAuthorSubscriptionAsync(AuthorSubscription authorSubscription);
        bool UpdateAuthorSubscription(AuthorSubscription authorSubscription);
        bool DeleteAuthorSubscription(AuthorSubscription authorSubscription);
    }
}
