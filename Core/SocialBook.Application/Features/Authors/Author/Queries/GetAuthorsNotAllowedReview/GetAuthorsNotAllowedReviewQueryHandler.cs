using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsNotAllowedReviewQueryHandler : IRequestHandler<GetAuthorsNotAllowedReviewQueryRequest, PaginatedListDto<AuthorDto>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsNotAllowedReviewQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorDto>> Handle(GetAuthorsNotAllowedReviewQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var authors = await _authorService.GetAuthorsNotAllowedReviewAsync(paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorDto>>(authors);
        }
    }
}
