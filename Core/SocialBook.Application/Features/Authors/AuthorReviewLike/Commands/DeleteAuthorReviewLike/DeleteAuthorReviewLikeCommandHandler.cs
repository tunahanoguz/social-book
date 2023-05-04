using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorReviewLikeCommandHandler : IRequestHandler<DeleteAuthorReviewLikeCommandRequest, bool>
    {
        private readonly IAuthorReviewLikeService _authorReviewLikeService;

        public DeleteAuthorReviewLikeCommandHandler(IAuthorReviewLikeService authorReviewService)
        {
            _authorReviewLikeService = authorReviewService;
        }

        public async Task<bool> Handle(DeleteAuthorReviewLikeCommandRequest request, CancellationToken cancellationToken)
        {
            return await _authorReviewLikeService.DeleteAuthorReviewLikeAsync(request.Id.ToString());
        }
    }
}
