using FluentValidation;
using SocialBook.Application.Features.Queries;

namespace SocialBook.Application.Validators.Authors
{
    public class GetAuthorsByFirstNameQueryRequestValidator : AbstractValidator<GetAuthorsByFirstNameQueryRequest>
    {
        public GetAuthorsByFirstNameQueryRequestValidator()
        {
            RuleFor(a => a.FirstName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please enter a first name!");

            RuleFor(a => a.FirstName)
                .MinimumLength(2)
                .WithMessage("The first name's length must be higher than 2 characters!");
        }
    }
}
