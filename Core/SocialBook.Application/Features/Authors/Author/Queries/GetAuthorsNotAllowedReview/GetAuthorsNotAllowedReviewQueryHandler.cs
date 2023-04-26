using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsNotAllowedReviewQueryHandler : IRequestHandler<GetAuthorsNotAllowedReviewQueryRequest, List<GetAuthorsNotAllowedReviewQueryResponse>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsNotAllowedReviewQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorsNotAllowedReviewQueryResponse>> Handle(GetAuthorsNotAllowedReviewQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsNotAllowedReviewAsync();

            return _mapper.Map<List<GetAuthorsNotAllowedReviewQueryResponse>>(authors);
        }
    }
}
