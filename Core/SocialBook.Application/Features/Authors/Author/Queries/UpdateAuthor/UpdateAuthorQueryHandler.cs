using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Features.Authors
{
    public class UpdateAuthorQueryHandler : IRequestHandler<UpdateAuthorQueryRequest, UpdateAuthorQueryResponse>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public UpdateAuthorQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<UpdateAuthorQueryResponse> Handle(UpdateAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            await _authorService.UpdateAuthorAsync(_mapper.Map<Author>(request));

            return new();
        }
    }
}
