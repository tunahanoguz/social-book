using AutoMapper;
using MediatR;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Commands
{
    public class DeleteAuthorQueryHandler : IRequestHandler<DeleteAuthorQueryRequest, DeleteAuthorQueryResponse>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public DeleteAuthorQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<DeleteAuthorQueryResponse> Handle(DeleteAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            await _authorService.DeleteAuthorByIdAsync(request.Id);

            return new();
        }
    }
}
