using MediatR;
using SocialBook.Application.DTOs.Authors.AuthorRecommendation;

namespace SocialBook.Application.Features.Commands
{
    public class CreateAuthorRecommendationCommandRequest : IRequest<AuthorRecommendationDto>
    {
    }
}
