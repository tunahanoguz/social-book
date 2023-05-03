using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorReview;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorReviewsByAuthorQueryHandler : IRequestHandler<GetAuthorReviewsByAuthorQueryRequest, PaginatedListDto<AuthorReviewDto>>
    {
        private readonly IAuthorReviewService _authorReviewService;
        private readonly IMapper _mapper;

        public GetAuthorReviewsByAuthorQueryHandler(IAuthorReviewService authorReviewService, IMapper mapper)
        {
            _authorReviewService = authorReviewService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorReviewDto>> Handle(GetAuthorReviewsByAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorReviewService.GetAuthorReviewsByAuthorAsync(request.AuthorId, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorReviewDto>>(data);
        }
    }
}
