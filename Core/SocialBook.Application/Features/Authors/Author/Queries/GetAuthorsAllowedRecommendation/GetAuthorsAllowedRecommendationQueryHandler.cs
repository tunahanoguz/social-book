using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsAllowedRecommendationQueryHandler : IRequestHandler<GetAuthorsAllowedRecommendationQueryRequest, List<GetAuthorsAllowedRecommendationQueryResponse>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsAllowedRecommendationQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorsAllowedRecommendationQueryResponse>> Handle(GetAuthorsAllowedRecommendationQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsAllowedRecommendationAsync();

            return _mapper.Map<List<GetAuthorsAllowedRecommendationQueryResponse>>(authors);
        }
    }
}
