using FluentValidation;
using SocialBook.Application.Features.Commands;

namespace SocialBook.Application.Validators.Authors.AuthorGenre
{
    public class CreateAuthorGenreCommandRequestValidator : AbstractValidator<CreateAuthorGenreCommandRequest>
    {
        public CreateAuthorGenreCommandRequestValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotNull()
                .NotEmpty()
                .WithMessage("The author identifier cannot be null or empty!");

            RuleFor(x => x.AuthorId)
                .Must(IsValidGuid)
                .WithMessage("The author identifier must be a valid GUID!");

            RuleFor(x => x.GenreId)
                .NotNull()
                .NotEmpty()
                .WithMessage("The genre identifier cannot be null or empty!");

            RuleFor(x => x.GenreId)
                .Must(IsValidGuid)
                .WithMessage("The genre identifier must be a valid GUID!");
        }

        private bool IsValidGuid(string id)
        {
            Guid guid;
            return Guid.TryParse(id, out guid);
        }
    }
}
