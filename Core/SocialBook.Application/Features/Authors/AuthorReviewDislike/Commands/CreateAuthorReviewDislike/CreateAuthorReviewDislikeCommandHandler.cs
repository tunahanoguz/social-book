using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewDislike;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorReviewDislikeCommandHandler : IRequestHandler<CreateAuthorReviewDislikeCommandRequest, AuthorReviewDislikeDto>
    {
        private readonly IAuthorReviewDislikeService _authorReviewDislikeService;
        private readonly IMapper _mapper;

        public CreateAuthorReviewDislikeCommandHandler(IAuthorReviewDislikeService authorReviewService, IMapper mapper)
        {
            _authorReviewDislikeService = authorReviewService;
            _mapper = mapper;
        }

        public async Task<AuthorReviewDislikeDto> Handle(CreateAuthorReviewDislikeCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _authorReviewDislikeService.CreateAuthorReviewDislikeAsync(_mapper.Map<AuthorReviewDislike>(request));

            return _mapper.Map<AuthorReviewDislikeDto>(data);
        }
    }
}
