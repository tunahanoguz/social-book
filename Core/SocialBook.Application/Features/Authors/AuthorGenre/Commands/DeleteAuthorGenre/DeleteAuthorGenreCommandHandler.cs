using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorGenreCommandHandler : IRequestHandler<DeleteAuthorGenreCommandRequest, bool>
    {
        private readonly IAuthorGenreService _authorGenreService;

        public DeleteAuthorGenreCommandHandler(IAuthorGenreService authorGenreService)
        {
            _authorGenreService = authorGenreService;
        }

        public async Task<bool> Handle(DeleteAuthorGenreCommandRequest request, CancellationToken cancellationToken)
        {
            return await _authorGenreService.DeleteAuthorGenreAsync(request.Id);
        }
    }
}
