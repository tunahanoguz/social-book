using AutoMapper;
using SocialBook.Application.DTOs.Authors.AuthorRecommendation;
using SocialBook.Application.Features.Commands;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorRecommendationMapping : Profile
    {
        public AuthorRecommendationMapping()
        {
            CreateMap<AuthorRecommendation, AuthorRecommendationDto>().ReverseMap();
            CreateMap<AuthorRecommendation, CreateAuthorRecommendationCommandRequest>().ReverseMap();
        }
    }
}
