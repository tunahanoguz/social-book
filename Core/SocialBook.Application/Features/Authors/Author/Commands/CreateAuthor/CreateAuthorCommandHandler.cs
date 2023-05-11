using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.Interfaces.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommandRequest, AuthorDto>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public CreateAuthorCommandHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<AuthorDto> Handle(CreateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var author = await _authorService.CreateAuthorAsync(_mapper.Map<Author>(request));

            return _mapper.Map<AuthorDto>(author);
        }
    }
}
