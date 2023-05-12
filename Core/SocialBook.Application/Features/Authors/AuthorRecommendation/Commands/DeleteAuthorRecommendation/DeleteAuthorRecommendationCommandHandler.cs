using MediatR;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorRecommendationCommandHandler : IRequestHandler<DeleteAuthorRecommendationCommandRequest, bool>
    {
        private readonly IAuthorRecommendationService _authorRecommendationService;

        public DeleteAuthorRecommendationCommandHandler(IAuthorRecommendationService authorRecommendationService)
        {
            _authorRecommendationService = authorRecommendationService;
        }

        public async Task<bool> Handle(DeleteAuthorRecommendationCommandRequest request, CancellationToken cancellationToken)
        {
            return await _authorRecommendationService.DeleteRecommendationAuthorAsync(request.Id.ToString());
        }
    }
}
