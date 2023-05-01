using FluentValidation;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Validators.Common;

namespace SocialBook.Application.Validators.Authors
{
    public class GetAuthorsNotAllowedReviewQueryRequestValidator : AbstractValidator<GetAuthorsNotAllowedReviewQueryRequest>
    {
        public GetAuthorsNotAllowedReviewQueryRequestValidator()
        {
            Include(new PaginationFilterValidator());
        }
    }
}
