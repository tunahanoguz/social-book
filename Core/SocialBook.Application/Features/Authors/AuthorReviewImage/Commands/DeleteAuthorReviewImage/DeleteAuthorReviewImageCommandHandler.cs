using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorReviewImageCommandHandler : IRequestHandler<DeleteAuthorReviewImageCommandRequest, bool>
    {
        private readonly IAuthorReviewImageService _authorReviewImageService;

        public DeleteAuthorReviewImageCommandHandler(IAuthorReviewImageService authorReviewImageService)
        {
            _authorReviewImageService = authorReviewImageService;
        }

        public async Task<bool> Handle(DeleteAuthorReviewImageCommandRequest request, CancellationToken cancellationToken)
        {
            return await _authorReviewImageService.DeleteAuthorReviewImageAsync(request.Id.ToString());
        }
    }
}
