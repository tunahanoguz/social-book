using AutoMapper;
using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorImage;
using SocialBook.Application.DTOs.Common;
using SocialBook.Application.Filters;
using SocialBook.Application.Services.Authors;

namespace SocialBook.Application.Features.Queries
{
    public class GetAuthorImagesByAuthorQueryHandler : IRequestHandler<GetAuthorImagesByAuthorQueryRequest, PaginatedListDto<AuthorImageDto>>
    {
        private readonly IAuthorImageService _authorImageService;
        private readonly IMapper _mapper;

        public GetAuthorImagesByAuthorQueryHandler(IAuthorImageService authorImageService, IMapper mapper)
        {
            _authorImageService = authorImageService;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<AuthorImageDto>> Handle(GetAuthorImagesByAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            var paginationFilter = new PaginationFilter(request.PageNumber, request.PageSize);
            var data = await _authorImageService.GetAuthorImagesByAuthorAsync(request.AuthorId, paginationFilter);

            return _mapper.Map<PaginatedListDto<AuthorImageDto>>(data);
        }
    }
}
