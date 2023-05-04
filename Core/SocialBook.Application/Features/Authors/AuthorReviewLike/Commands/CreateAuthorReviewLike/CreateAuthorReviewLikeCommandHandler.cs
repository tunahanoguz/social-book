using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReviewLike;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorReviewLikeCommandHandler : IRequestHandler<CreateAuthorReviewLikeCommandRequest, AuthorReviewLikeDto>
    {
        private readonly IAuthorReviewLikeService _authorReviewLikeService;
        private readonly IMapper _mapper;

        public CreateAuthorReviewLikeCommandHandler(IAuthorReviewLikeService authorReviewService, IMapper mapper)
        {
            _authorReviewLikeService = authorReviewService;
            _mapper = mapper;
        }

        public async Task<AuthorReviewLikeDto> Handle(CreateAuthorReviewLikeCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _authorReviewLikeService.CreateAuthorReviewLikeAsync(_mapper.Map<AuthorReviewLike>(request));

            return _mapper.Map<AuthorReviewLikeDto>(data);
        }
    }
}
