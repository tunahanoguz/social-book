using SocialBook.Application.Repositories.Authors;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.Services.Authors
{
    public class AuthorRecommendationService : IAuthorRecommendationService
    {
        private readonly IAuthorRecommendationReadRepository _authorRecommendationReadRepository;
        private readonly IAuthorRecommendationWriteRepository _authorRecommendationWriteRepository;

        public AuthorRecommendationService(IAuthorRecommendationReadRepository authorRecommendationReadRepository,
            IAuthorRecommendationWriteRepository authorRecommendationWriteRepository)
        {
            _authorRecommendationReadRepository = authorRecommendationReadRepository;
            _authorRecommendationWriteRepository = authorRecommendationWriteRepository;
        }

        public async Task<List<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorRecommendationReadRepository.GetAuthorRecommendationsByAuthorAsync(authorId);
        }

        public Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId)
        {
            if (recommenderUserId == null) { throw new ArgumentNullException(nameof(recommenderUserId)); }

            return _authorRecommendationReadRepository.GetAuthorRecommendationsByRecommenderUserAsync(recommenderUserId);
        }

        public Task<List<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId)
        {
            if (recipientUserId == null) { throw new ArgumentNullException(nameof(recipientUserId)); }

            return _authorRecommendationReadRepository.GetAuthorRecommendationsByRecipientUserAsync(recipientUserId);
        }

        public async Task<bool> CreateAuthorRecommendationAsync(AuthorRecommendation authorRecommendation)
        {
            if (authorRecommendation == null) { throw new ArgumentNullException(nameof(authorRecommendation)); }

            return await _authorRecommendationWriteRepository.AddAsync(authorRecommendation);
        }

        public bool UpdateRecommendationAuthor(AuthorRecommendation authorRecommendation)
        {
            if (authorRecommendation == null) { throw new ArgumentNullException(nameof(authorRecommendation)); }

            return _authorRecommendationWriteRepository.Update(authorRecommendation);
        }

        public bool DeleteRecommendationAuthor(AuthorRecommendation authorRecommendation)
        {
            if (authorRecommendation == null) { throw new ArgumentNullException(nameof(authorRecommendation)); }

            return _authorRecommendationWriteRepository.Remove(authorRecommendation);
        }
    }
}
