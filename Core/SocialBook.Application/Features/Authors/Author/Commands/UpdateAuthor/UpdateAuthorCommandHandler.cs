using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.Interfaces.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommandRequest, AuthorDto>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public UpdateAuthorCommandHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<AuthorDto> Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var author = await _authorService.UpdateAuthorAsync(_mapper.Map<Author>(request));

            return _mapper.Map<AuthorDto>(author);
        }
    }
}
