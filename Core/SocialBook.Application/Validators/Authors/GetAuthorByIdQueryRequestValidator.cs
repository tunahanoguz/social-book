using FluentValidation;
using SocialBook.Application.Features.Queries;

namespace SocialBook.Application.Validators.Authors
{
    public class GetAuthorByIdQueryRequestValidator : AbstractValidator<GetAuthorByIdQueryRequest>
    {
        public GetAuthorByIdQueryRequestValidator()
        {
            RuleFor(a => a.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("The identifier cannot be null or empty!");

            RuleFor(a => a.Id)
                .Must(IsValidGuid)
                .WithMessage("The identifier must be a valid GUID!");
        }

        private bool IsValidGuid(string id)
        {
            Guid guid;
            return Guid.TryParse(id, out guid);
        }
    }
}
