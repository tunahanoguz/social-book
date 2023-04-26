using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsNotAllowedSubscriptionQueryHandler : IRequestHandler<GetAuthorsNotAllowedSubscriptionQueryRequest, List<GetAuthorsNotAllowedSubscriptionQueryResponse>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsNotAllowedSubscriptionQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorsNotAllowedSubscriptionQueryResponse>> Handle(GetAuthorsNotAllowedSubscriptionQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsNotAllowedSubscriptionAsync();

            return _mapper.Map<List<GetAuthorsNotAllowedSubscriptionQueryResponse>>(authors);
        }
    }
}
