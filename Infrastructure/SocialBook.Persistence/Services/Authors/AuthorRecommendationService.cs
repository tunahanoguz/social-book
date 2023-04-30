using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
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

        /// <inheritdoc />
        public async Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByAuthorAsync(Guid authorId, PaginationFilter paginationFilter)
        {
            if (authorId == Guid.Empty) { throw new ArgumentNullException(nameof(authorId)); }

            return await _authorRecommendationReadRepository.GetAuthorRecommendationsByAuthorAsync(authorId, paginationFilter);
        }

        /// <inheritdoc />
        public Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByRecommenderUserAsync(string recommenderUserId, PaginationFilter paginationFilter)
        {
            if (recommenderUserId == null) { throw new ArgumentNullException(nameof(recommenderUserId)); }

            return _authorRecommendationReadRepository.GetAuthorRecommendationsByRecommenderUserAsync(recommenderUserId, paginationFilter);
        }

        /// <inheritdoc />
        public Task<PaginatedListDto<AuthorRecommendation>> GetAuthorRecommendationsByRecipientUserAsync(string recipientUserId, PaginationFilter paginationFilter)
        {
            if (recipientUserId == null) { throw new ArgumentNullException(nameof(recipientUserId)); }

            return _authorRecommendationReadRepository.GetAuthorRecommendationsByRecipientUserAsync(recipientUserId, paginationFilter);
        }

        /// <inheritdoc />
        public async Task<bool> CreateAuthorRecommendationAsync(AuthorRecommendation authorRecommendation)
        {
            if (authorRecommendation == null) { throw new ArgumentNullException(nameof(authorRecommendation)); }

            return await _authorRecommendationWriteRepository.AddAsync(authorRecommendation);
        }

        /// <inheritdoc />
        public bool UpdateRecommendationAuthor(AuthorRecommendation authorRecommendation)
        {
            if (authorRecommendation == null) { throw new ArgumentNullException(nameof(authorRecommendation)); }

            return _authorRecommendationWriteRepository.Update(authorRecommendation);
        }

        /// <inheritdoc />
        public bool DeleteRecommendationAuthor(AuthorRecommendation authorRecommendation)
        {
            if (authorRecommendation == null) { throw new ArgumentNullException(nameof(authorRecommendation)); }

            return _authorRecommendationWriteRepository.Remove(authorRecommendation);
        }
    }
}
