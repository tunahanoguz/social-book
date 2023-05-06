using AutoMapper;
using SocialBook.Application.DTOs.Authors.AuthorReviewImage;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorReviewImageMapping : Profile
    {
        public AuthorReviewImageMapping()
        {
            CreateMap<AuthorReviewImage, AuthorReviewImageDto>().ReverseMap();
        }
    }
}
