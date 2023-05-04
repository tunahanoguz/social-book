using AutoMapper;
using SocialBook.Application.DTOs.Authors.AuthorReviewLike;
using SocialBook.Application.Features.Commands;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorReviewLikeMapping : Profile
    {
        public AuthorReviewLikeMapping()
        {
            CreateMap<AuthorReviewLike, AuthorReviewLikeDto>().ReverseMap();
            CreateMap<AuthorReviewLike, CreateAuthorReviewLikeCommandRequest>().ReverseMap();
        }
    }
}
