using FluentValidation;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Validators.Common;

namespace SocialBook.Application.Validators.Authors
{
    public class GetAuthorsByCountryOfBirthQueryRequestValidator : AbstractValidator<GetAuthorsByCountryOfBirthQueryRequest>
    {
        public GetAuthorsByCountryOfBirthQueryRequestValidator()
        {
            Include(new PaginationFilterValidator());

            RuleFor(x => x.CountryOfBirth)
                .NotNull()
                .NotEmpty()
                .WithMessage("The country of birth cannot be null or empty!");
        }
    }
}
