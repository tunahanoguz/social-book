using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.Results;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsByFirstNameQueryHandler : IRequestHandler<GetAuthorsByFirstNameQueryRequest, IPaginatedDataResult<AuthorDto>>
    {
        private readonly IAuthorService _authorService;

        public GetAuthorsByFirstNameQueryHandler(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public async Task<IPaginatedDataResult<AuthorDto>> Handle(GetAuthorsByFirstNameQueryRequest request, CancellationToken cancellationToken)
        {
            return await _authorService.GetAuthorsByFirstNameAsync(request.FirstName, request.PaginationFilter);
        }
    }
}
