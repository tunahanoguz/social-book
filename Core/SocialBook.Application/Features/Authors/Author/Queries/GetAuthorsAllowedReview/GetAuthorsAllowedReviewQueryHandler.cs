using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedReviewQueryHandler : IRequestHandler<GetAuthorsAllowedReviewQueryRequest, List<GetAuthorsAllowedReviewQueryResponse>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsAllowedReviewQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorsAllowedReviewQueryResponse>> Handle(GetAuthorsAllowedReviewQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsAllowedReviewAsync();

            return _mapper.Map<List<GetAuthorsAllowedReviewQueryResponse>>(authors);
        }
    }
}
