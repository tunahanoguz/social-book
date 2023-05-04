using FluentValidation;
using SocialBook.Application.Features.Queries;

namespace SocialBook.Application.Validators.Authors.AuthorReviewDislike
{
    public class GetAuthorReviewDislikesByUserQueryRequestValidator : AbstractValidator<GetAuthorReviewDislikesByUserQueryRequest>
    {
        public GetAuthorReviewDislikesByUserQueryRequestValidator()
        {
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
