using MediatR;
using SocialBook.Application.Features.Commands;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Authors.AuthorImage.Commands.DeleteAuthorImage
{
    public class DeleteAuthorImageCommandHandler : IRequestHandler<DeleteAuthorImageCommandRequest, bool>
    {
        private readonly IAuthorImageService _authorImageService;

        public DeleteAuthorImageCommandHandler(IAuthorImageService authorImageService)
        {
            _authorImageService = authorImageService;
        }

        public async Task<bool> Handle(DeleteAuthorImageCommandRequest request, CancellationToken cancellationToken)
        {
            return await _authorImageService.DeleteAuthorImageAsync(request.Id.ToString());
        }
    }
}
