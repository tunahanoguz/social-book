using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedReviewQueryHandler : IRequestHandler<GetAuthorsAllowedReviewQueryRequest, PaginatedListDto<AuthorDto>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsAllowedReviewQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorDto>> Handle(GetAuthorsAllowedReviewQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorService.GetAuthorsAllowedReviewAsync(new PaginationFilter(request.PageNumber, request.PageSize));

            return _mapper.Map<PaginatedListDto<AuthorDto>>(authors);
        }
    }
}
