using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsByLastNameQueryHandler : IRequestHandler<GetAuthorsByLastNameQueryRequest, List<GetAuthorsByLastNameQueryResponse>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsByLastNameQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorsByLastNameQueryResponse>> Handle(GetAuthorsByLastNameQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsByLastNameAsync(request.LastName);

            return _mapper.Map<List<GetAuthorsByLastNameQueryResponse>>(authors);
        }
    }
}
