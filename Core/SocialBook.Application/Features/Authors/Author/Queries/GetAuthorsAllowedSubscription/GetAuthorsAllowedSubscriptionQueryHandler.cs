using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedSubscriptionQueryHandler : IRequestHandler<GetAuthorsAllowedSubscriptionQueryRequest, PaginatedListDto<AuthorDto>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsAllowedSubscriptionQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorDto>> Handle(GetAuthorsAllowedSubscriptionQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsAllowedSubscriptionAsync(new PaginationFilter(request.PageNumber, request.PageSize));

            return _mapper.Map<PaginatedListDto<AuthorDto>>(authors);
        }
    }
}
