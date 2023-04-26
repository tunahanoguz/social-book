using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByCreatorUserQueryHandler : IRequestHandler<GetAuthorsByCreatorUserQueryRequest, List<GetAuthorsByCreatorUserQueryResponse>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsByCreatorUserQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorsByCreatorUserQueryResponse>> Handle(GetAuthorsByCreatorUserQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsByCreatorUserAsync(request.CreatorUserId);

            return _mapper.Map<List<GetAuthorsByCreatorUserQueryResponse>>(authors);
        }
    }
}
