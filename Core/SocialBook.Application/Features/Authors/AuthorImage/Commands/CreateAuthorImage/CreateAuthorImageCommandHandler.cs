using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorImage;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorImageCommandHandler : IRequestHandler<CreateAuthorImageCommandRequest, AuthorImageDto>
    {
        private readonly IAuthorImageService _authorImageService;
        private readonly IMapper _mapper;

        public CreateAuthorImageCommandHandler(IAuthorImageService authorImageService, IMapper mapper)
        {
            _authorImageService = authorImageService;
            _mapper = mapper;
        }

        public async Task<AuthorImageDto> Handle(CreateAuthorImageCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _authorImageService.CreateAuthorImageAsync(request.AuthorId, request.Image);

            return _mapper.Map<AuthorImageDto>(data);
        }
    }
}
