using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQueryRequest, GetAuthorByIdQueryResponse>
    {
        private readonly IAuthorService _authorService;

        public GetAuthorByIdQueryHandler(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public async Task<GetAuthorByIdQueryResponse> Handle(GetAuthorByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var author = await _authorService.GetAuthorById(request.AuthorId);
            return new() { Author = author };
        }
    }
}
