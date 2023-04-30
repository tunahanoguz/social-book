using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByFirstNameQueryHandler : IRequestHandler<GetAuthorsByFirstNameQueryRequest, PaginatedListDto<AuthorDto>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsByFirstNameQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorDto>> Handle(GetAuthorsByFirstNameQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsByFirstNameAsync(request.FirstName, request.PaginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorDto>>(authors);
        }
    }
}
