using FluentValidation;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Validators.Common;

namespace SocialBook.Application.Validators.Authors
{
    public class GetAuthorsAllowedReviewQueryRequestValidator : AbstractValidator<GetAuthorsAllowedReviewQueryRequest>
    {
        public GetAuthorsAllowedReviewQueryRequestValidator()
        {
            Include(new PaginationFilterValidator());
        }
    }
}
