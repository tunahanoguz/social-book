using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorReviewCommandHandler : IRequestHandler<DeleteAuthorReviewCommandRequest, bool>
    {
        private readonly IAuthorReviewService _authorReviewService;

        public DeleteAuthorReviewCommandHandler(IAuthorReviewService authorReviewService)
        {
            _authorReviewService = authorReviewService;
        }

        public async Task<bool> Handle(DeleteAuthorReviewCommandRequest request, CancellationToken cancellationToken)
        {
            return await _authorReviewService.DeleteAuthorReviewAsync(request.Id.ToString());
        }
    }
}
