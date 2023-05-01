using FluentValidation;
using SocialBook.Application.Filters;

namespace SocialBook.Application.Validators.Common
{
    public class PaginationFilterValidator : AbstractValidator<PaginationFilter>
    {
        public PaginationFilterValidator()
        {
            RuleFor(x => x.PageNumber)
                .GreaterThanOrEqualTo(1)
                .WithMessage("The page number must be grater than zero!");

            RuleFor(x => x.PageSize)
                .GreaterThanOrEqualTo(1)
                .WithMessage("The page size must be grater than zero!");
        }
    }
}
