using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorReviewDislikeCommandHandler : IRequestHandler<DeleteAuthorReviewDislikeCommandRequest, bool>
    {
        private readonly IAuthorReviewDislikeService _authorReviewDislikeService;

        public DeleteAuthorReviewDislikeCommandHandler(IAuthorReviewDislikeService authorReviewService)
        {
            _authorReviewDislikeService = authorReviewService;
        }

        public async Task<bool> Handle(DeleteAuthorReviewDislikeCommandRequest request, CancellationToken cancellationToken)
        {
            return await _authorReviewDislikeService.DeleteAuthorReviewDislikeAsync(request.Id.ToString());
        }
    }
}
