using FluentValidation;
using SocialBook.Application.Features.Commands;

namespace SocialBook.Application.Validators.Authors.AuthorImage
{
    public class CreateAuthorImageCommandRequestValidator : AbstractValidator<CreateAuthorImageCommandRequest>
    {
        public CreateAuthorImageCommandRequestValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotNull()
                .NotEmpty()
                .WithMessage("The author identifier cannot be null or empty!");

            RuleFor(x => x.AuthorId)
                .Must(authorId => IsValidGuid(authorId.ToString()))
                .WithMessage("The author identifier must be a valid GUID!");
        }

        private bool IsValidGuid(string id)
        {
            Guid guid;
            return Guid.TryParse(id, out guid);
        }
    }
}
