using FluentValidation;
using SocialBook.Application.Features.Commands;

namespace SocialBook.Application.Validators.Authors.AuthorReviewLike
{
    public class CreateAuthorReviewLikeCommandRequestValidator : AbstractValidator<CreateAuthorReviewLikeCommandRequest>
    {
        public CreateAuthorReviewLikeCommandRequestValidator()
        {
            RuleFor(x => x.AuthorReviewId)
                .NotNull()
                .NotEmpty()
                .WithMessage("The author review identifier cannot be null or empty!");

            RuleFor(x => x.AuthorReviewId)
                .Must(authorReviewId => IsValidGuid(authorReviewId.ToString()))
                .WithMessage("The author review identifier must be a valid GUID!");

            RuleFor(x => x.UserId)
                .NotNull()
                .NotEmpty()
                .WithMessage("The user identifier cannot be null or empty!");

            RuleFor(x => x.UserId)
                .Must(IsValidGuid)
                .WithMessage("The user identifier must be a valid GUID!");
        }

        private bool IsValidGuid(string id)
        {
            Guid guid;
            return Guid.TryParse(id, out guid);
        }
    }
}
