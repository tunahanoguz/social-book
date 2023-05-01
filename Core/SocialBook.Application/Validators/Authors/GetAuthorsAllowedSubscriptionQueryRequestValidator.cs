using FluentValidation;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Validators.Common;

namespace SocialBook.Application.Validators.Authors
{
    public class GetAuthorsAllowedSubscriptionQueryRequestValidator : AbstractValidator<GetAuthorsAllowedSubscriptionQueryRequest>
    {
        public GetAuthorsAllowedSubscriptionQueryRequestValidator()
        {
            Include(new PaginationFilterValidator());
        }
    }
}
