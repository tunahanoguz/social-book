using AutoMapper;
using SocialBook.Application.DTOs.Authors.AuthorSubscription;
using SocialBook.Application.Features.Commands;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Application.Mappings.Authors
{
    public class AuthorSubscriptionMapping : Profile
    {
        public AuthorSubscriptionMapping()
        {
            CreateMap<AuthorSubscription, AuthorSubscriptionDto>().ReverseMap();
            CreateMap<AuthorSubscription, CreateAuthorSubscriptionCommandRequest>().ReverseMap();
        }
    }
}
