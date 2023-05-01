using FluentValidation;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Validators.Common;

namespace SocialBook.Application.Validators.Authors
{
    public class GetAuthorsByLastNameQueryRequestValidator : AbstractValidator<GetAuthorsByLastNameQueryRequest>
    {
        public GetAuthorsByLastNameQueryRequestValidator()
        {
            Include(new PaginationFilterValidator());

            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please enter a last name!");

            RuleFor(a => a.LastName)
                .MinimumLength(2)
                .WithMessage("The last name's length must be higher than 2 characters!");
        }
    }
}
