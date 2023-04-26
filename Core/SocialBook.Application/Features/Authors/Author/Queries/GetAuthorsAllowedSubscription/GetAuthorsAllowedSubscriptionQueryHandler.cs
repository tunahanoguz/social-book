using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedSubscriptionQueryHandler : IRequestHandler<GetAuthorsAllowedSubscriptionQueryRequest, List<GetAuthorsAllowedSubscriptionQueryResponse>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsAllowedSubscriptionQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorsAllowedSubscriptionQueryResponse>> Handle(GetAuthorsAllowedSubscriptionQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsAllowedSubscriptionAsync();

            return _mapper.Map<List<GetAuthorsAllowedSubscriptionQueryResponse>>(authors);
        }
    }
}
