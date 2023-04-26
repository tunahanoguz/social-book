using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsNotAllowedRecommendationQueryHandler : IRequestHandler<GetAuthorsNotAllowedRecommendationQueryRequest, List<GetAuthorsNotAllowedRecommendationQueryResponse>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsNotAllowedRecommendationQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorsNotAllowedRecommendationQueryResponse>> Handle(GetAuthorsNotAllowedRecommendationQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsNotAllowedRecommendationAsync();

            return _mapper.Map<List<GetAuthorsNotAllowedRecommendationQueryResponse>>(authors);
        }
    }
}
