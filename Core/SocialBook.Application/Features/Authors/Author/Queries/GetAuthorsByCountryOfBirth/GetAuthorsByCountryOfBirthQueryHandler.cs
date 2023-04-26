using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByCountryOfBirthQueryHandler : IRequestHandler<GetAuthorsByCountryOfBirthQueryRequest, List<GetAuthorsByCountryOfBirthQueryResponse>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsByCountryOfBirthQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorsByCountryOfBirthQueryResponse>> Handle(GetAuthorsByCountryOfBirthQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsByCountryOfBirthAsync(request.CountryOfBirth);

            return _mapper.Map<List<GetAuthorsByCountryOfBirthQueryResponse>>(authors);
        }
    }
}
