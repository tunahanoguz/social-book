using AutoMapper;
using SocialBook.Application.DTOs.Authors.AuthorRecommendation;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorRecommendationMapping : Profile
    {
        public AuthorRecommendationMapping()
        {
            CreateMap<AuthorRecommendation, AuthorRecommendationDto>();
        }
    }
}
