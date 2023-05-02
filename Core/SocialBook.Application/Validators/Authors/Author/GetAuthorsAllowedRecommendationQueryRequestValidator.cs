using FluentValidation;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Validators.Common;

namespace SocialBook.Application.Validators.Authors.Author
{
    public class GetAuthorsAllowedRecommendationQueryRequestValidator : AbstractValidator<GetAuthorsAllowedRecommendationQueryRequest>
    {
        public GetAuthorsAllowedRecommendationQueryRequestValidator()
        {
            Include(new PaginationFilterValidator());
        }
    }
}
