using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorQueryHandler : IRequestHandler<CreateAuthorQueryRequest, AuthorDto>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public CreateAuthorQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<AuthorDto> Handle(CreateAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            var author = await _authorService.CreateAuthorAsync(_mapper.Map<Author>(request));

            return _mapper.Map<AuthorDto>(author);
        }
    }
}
