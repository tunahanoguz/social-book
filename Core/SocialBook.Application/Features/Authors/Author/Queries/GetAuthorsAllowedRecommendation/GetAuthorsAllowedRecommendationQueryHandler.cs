using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.Author;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorsAllowedRecommendationQueryHandler : IRequestHandler<GetAuthorsAllowedRecommendationQueryRequest, PaginatedListDto<AuthorDto>>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAuthorsAllowedRecommendationQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorDto>> Handle(GetAuthorsAllowedRecommendationQueryRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<PaginatedListDto<AuthorDto>>(_authorService.GetAuthorsAllowedRecommendationAsync(new PaginationFilter(request.PageNumber, request.PageSize)));
        }
    }
}
