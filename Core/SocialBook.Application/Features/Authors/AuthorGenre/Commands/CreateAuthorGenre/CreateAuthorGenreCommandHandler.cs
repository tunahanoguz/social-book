using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorGenre;
using SocialBook.Application.Interfaces.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorGenreCommandHandler : IRequestHandler<CreateAuthorGenreCommandRequest, AuthorGenreDto>
    {
        private readonly IAuthorGenreService _authorGenreService;
        private readonly IMapper _mapper;

        public CreateAuthorGenreCommandHandler(IAuthorGenreService authorGenreService, IMapper mapper)
        {
            _authorGenreService = authorGenreService;
            _mapper = mapper;
        }

        public async Task<AuthorGenreDto> Handle(CreateAuthorGenreCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _authorGenreService.CreateAuthorGenreAsync(_mapper.Map<AuthorGenre>(request));

            return _mapper.Map<AuthorGenreDto>(data);
        }
    }
}
