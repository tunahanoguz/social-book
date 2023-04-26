using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsByYearOfBirthQueryHandler : IRequestHandler<GetAuthorsByYearOfBirthQueryRequest, List<GetAuthorsByYearOfBirthQueryResponse>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsByYearOfBirthQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorsByYearOfBirthQueryResponse>> Handle(GetAuthorsByYearOfBirthQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsByYearOfBirthAsync(request.YearOfBirth);

            return _mapper.Map<List<GetAuthorsByYearOfBirthQueryResponse>>(authors);
        }
    }
}
