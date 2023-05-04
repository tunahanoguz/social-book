using FluentValidation;
using SocialBook.Application.Features.Authors.AuthorReviewLike.Queries.GetAuthorReviewLikesByUser;

namespace SocialBook.Application.Validators.Authors.AuthorReviewLike
{
    public class GetAuthorReviewLikesByUserQueryRequestValidator : AbstractValidator<GetAuthorReviewLikesByUserQueryRequest>
    {
        public GetAuthorReviewLikesByUserQueryRequestValidator()
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
