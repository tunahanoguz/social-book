using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewImage;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorReviewImageCommandHandler : IRequestHandler<CreateAuthorReviewImageCommandRequest, AuthorReviewImageDto>
    {
        private readonly IAuthorReviewImageService _authorReviewImageService;
        private readonly IMapper _mapper;

        public CreateAuthorReviewImageCommandHandler(IAuthorReviewImageService authorReviewImageService, IMapper mapper)
        {
            _authorReviewImageService = authorReviewImageService;
            _mapper = mapper;
        }

        public async Task<AuthorReviewImageDto> Handle(CreateAuthorReviewImageCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _authorReviewImageService.CreateAuthorReviewImageAsync(request.AuthorReviewId, request.Image);

            return _mapper.Map<AuthorReviewImageDto>(data);
        }
    }
}
