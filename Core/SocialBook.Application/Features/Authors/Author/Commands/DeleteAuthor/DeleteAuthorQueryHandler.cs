using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorQueryHandler : IRequestHandler<DeleteAuthorQueryRequest, AuthorDto>
    {
        private readonly IAuthorService _authorService;

        public DeleteAuthorQueryHandler(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public async Task<AuthorDto> Handle(DeleteAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            await _authorService.DeleteAuthorByIdAsync(request.Id);

            return new();
        }
    }
}
