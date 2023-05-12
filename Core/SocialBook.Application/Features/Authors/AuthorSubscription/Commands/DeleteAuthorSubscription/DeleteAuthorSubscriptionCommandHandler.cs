using MediatR;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorSubscriptionCommandHandler : IRequestHandler<DeleteAuthorSubscriptionCommandRequest, bool>
    {
        private readonly IAuthorSubscriptionService _authorSubscriptionService;

        public DeleteAuthorSubscriptionCommandHandler(IAuthorSubscriptionService authorSubscriptionService)
        {
            _authorSubscriptionService = authorSubscriptionService;
        }

        public async Task<bool> Handle(DeleteAuthorSubscriptionCommandRequest request, CancellationToken cancellationToken)
        {
            return await _authorSubscriptionService.DeleteAuthorSubscriptionAsync(request.Id.ToString());
        }
    }
}
