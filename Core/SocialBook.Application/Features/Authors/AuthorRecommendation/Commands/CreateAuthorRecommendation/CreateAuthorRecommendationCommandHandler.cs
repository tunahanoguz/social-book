using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorRecommendation;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorRecommendationCommandHandler : IRequestHandler<CreateAuthorRecommendationCommandRequest, AuthorRecommendationDto>
    {
        private readonly IAuthorRecommendationService _authorRecommendationService;
        private readonly IMapper _mapper;

        public CreateAuthorRecommendationCommandHandler(IAuthorRecommendationService authorRecommendationService, IMapper mapper)
        {
            _authorRecommendationService = authorRecommendationService;
            _mapper = mapper;
        }

        public async Task<AuthorRecommendationDto> Handle(CreateAuthorRecommendationCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _authorRecommendationService.CreateAuthorRecommendationAsync(_mapper.Map<AuthorRecommendation>(request));

            return _mapper.Map<AuthorRecommendationDto>(data);
        }
    }
}
