using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorRecommendation;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Interfaces.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorRecommendationsByAuthorQueryHandler : IRequestHandler<GetAuthorRecommendationsByAuthorQueryRequest, PaginatedListDto<AuthorRecommendationDto>>
    {
        private readonly IAuthorRecommendationService _authorRecommendationService;
        private readonly IMapper _mapper;

        public GetAuthorRecommendationsByAuthorQueryHandler(IAuthorRecommendationService authorRecommendationService, IMapper mapper)
        {
            _authorRecommendationService = authorRecommendationService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorRecommendationDto>> Handle(GetAuthorRecommendationsByAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorRecommendationService.GetAuthorRecommendationsByAuthorAsync(request.AuthorId, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorRecommendationDto>>(data);
        }
    }
}
