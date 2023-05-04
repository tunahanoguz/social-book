using FluentValidation;
using SocialBook.Application.Features.Queries;

namespace SocialBook.Application.Validators.Authors.AuthorReviewDislike
{
    public class GetAuthorReviewDislikesByAuthorReviewQueryRequestValidator : AbstractValidator<GetAuthorReviewDislikesByAuthorReviewQueryRequest>
    {
        public GetAuthorReviewDislikesByAuthorReviewQueryRequestValidator()
        {
            RuleFor(x => x.AuthorReviewId)
                .NotNull()
                .NotEmpty()
                .WithMessage("The author review identifier cannot be null or empty!");

            RuleFor(x => x.AuthorReviewId)
                .Must(authorReviewId => IsValidGuid(authorReviewId.ToString()))
                .WithMessage("The author review identifier must be a valid GUID!");
        }

        private bool IsValidGuid(string id)
        {
            Guid guid;
            return Guid.TryParse(id, out guid);
        }
    }
}
