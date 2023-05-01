using FluentValidation;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Validators.Common;

namespace SocialBook.Application.Validators.Authors
{
    public class GetAuthorsNotAllowedRecommendationQueryRequestValidator : AbstractValidator<GetAuthorsNotAllowedRecommendationQueryRequest>
    {
        public GetAuthorsNotAllowedRecommendationQueryRequestValidator()
        {
            Include(new PaginationFilterValidator());
        }
    }
}
