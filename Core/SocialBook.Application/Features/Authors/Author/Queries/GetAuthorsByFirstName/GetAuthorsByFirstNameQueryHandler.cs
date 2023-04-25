using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Authors
{
    public class GetAuthorsByFirstNameQueryHandler : IRequestHandler<GetAuthorsByFirstNameQueryRequest, GetAuthorsByFirstNameQueryResponse>
    {
        private readonly IAuthorService _authorService;

        public GetAuthorsByFirstNameQueryHandler(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public async Task<GetAuthorsByFirstNameQueryResponse> Handle(GetAuthorsByFirstNameQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsByFirstNameAsync(request.FirstName);

            return new() { Authors = authors };
        }
    }
}
