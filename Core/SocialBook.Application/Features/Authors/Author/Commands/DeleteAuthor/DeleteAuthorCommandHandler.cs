using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommandRequest, AuthorDto>
    {
        private readonly IAuthorService _authorService;

        public DeleteAuthorCommandHandler(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public async Task<AuthorDto> Handle(DeleteAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            await _authorService.DeleteAuthorByIdAsync(request.Id);

            return new();
        }
    }
}
