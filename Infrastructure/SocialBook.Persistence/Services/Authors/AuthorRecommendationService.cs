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
        public async Task<AuthorRecommendation> CreateAuthorRecommendationAsync(AuthorRecommendation authorRecommendation)
        {
            if (authorRecommendation == null) { throw new ArgumentNullException(nameof(authorRecommendation)); }

            await _authorRecommendationWriteRepository.AddAsync(authorRecommendation);
            await _authorRecommendationWriteRepository.SaveAsync();

            return await _authorRecommendationReadRepository.GetByIdAsync(authorRecommendation.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<AuthorRecommendation> UpdateRecommendationAuthorAsync(AuthorRecommendation authorRecommendation)
        {
            if (authorRecommendation == null) { throw new ArgumentNullException(nameof(authorRecommendation)); }

            _authorRecommendationWriteRepository.Update(authorRecommendation);
            await _authorRecommendationWriteRepository.SaveAsync();

            return await _authorRecommendationReadRepository.GetByIdAsync(authorRecommendation.Id.ToString(), false);
        }

        /// <inheritdoc />
        public async Task<bool> DeleteRecommendationAuthorAsync(string id)
        {
            if (id == null) { throw new ArgumentNullException(nameof(id)); }

            await _authorRecommendationWriteRepository.RemoveAsync(id);
            int affectedCount = await _authorRecommendationWriteRepository.SaveAsync();

            return affectedCount > 0;
        }
    }
}
