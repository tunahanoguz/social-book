using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByFirstNameQueryHandler : IRequestHandler<GetAuthorsByFirstNameQueryRequest, List<GetAuthorsByFirstNameQueryResponse>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsByFirstNameQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorsByFirstNameQueryResponse>> Handle(GetAuthorsByFirstNameQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsByFirstNameAsync(request.FirstName);

            return _mapper.Map<List<GetAuthorsByFirstNameQueryResponse>>(authors);
        }
    }
}
