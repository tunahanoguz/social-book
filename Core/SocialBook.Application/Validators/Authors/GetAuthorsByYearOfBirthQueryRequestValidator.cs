using FluentValidation;
using SocialBook.Application.Features.Queries;
using SocialBook.Application.Validators.Common;

namespace SocialBook.Application.Validators.Authors
{
    public class GetAuthorsByYearOfBirthQueryRequestValidator : AbstractValidator<GetAuthorsByYearOfBirthQueryRequest>
    {
        public GetAuthorsByYearOfBirthQueryRequestValidator()
        {
            Include(new PaginationFilterValidator());

            RuleFor(x => x.YearOfBirth)
                .NotNull()
                .NotEmpty()
                .WithMessage("The year of birth cannot be null or empty!");
        }
    }
}
