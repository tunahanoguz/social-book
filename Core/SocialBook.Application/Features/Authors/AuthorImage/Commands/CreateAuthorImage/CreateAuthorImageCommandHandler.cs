using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorImageCommandHandler : IRequestHandler<CreateAuthorImageCommandRequest, bool>
    {
        private readonly IAuthorImageService _authorImageService;
        private readonly IMapper _mapper;

        public CreateAuthorImageCommandHandler(IAuthorImageService authorImageService, IMapper mapper)
        {
            _authorImageService = authorImageService;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateAuthorImageCommandRequest request, CancellationToken cancellationToken)
        {
            var author = await _authorImageService.CreateAuthorImageAsync(request.AuthorId, request.Image);

            return true;
        }
    }
}
