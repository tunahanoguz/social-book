using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReview;
using SocialBook.Application.Interfaces.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorReviewCommandHandler : IRequestHandler<CreateAuthorReviewCommandRequest, AuthorReviewDto>
    {
        private readonly IAuthorReviewService _authorReviewService;
        private readonly IMapper _mapper;

        public CreateAuthorReviewCommandHandler(IAuthorReviewService authorReviewService, IMapper mapper)
        {
            _authorReviewService = authorReviewService;
            _mapper = mapper;
        }

        public async Task<AuthorReviewDto> Handle(CreateAuthorReviewCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _authorReviewService.CreateAuthorReviewAsync(_mapper.Map<AuthorReview>(request));

            return _mapper.Map<AuthorReviewDto>(data);
        }
    }
}
