using AutoMapper;
using SocialBook.Application.DTOs.Authors.AuthorReview;
using SocialBook.Application.Features.Commands;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorReviewMapping : Profile
    {
        public AuthorReviewMapping()
        {
            CreateMap<AuthorReview, AuthorReviewDto>().ReverseMap();
            CreateMap<AuthorReview, CreateAuthorReviewCommandRequest>().ReverseMap();
        }
    }
}
