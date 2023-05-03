using FluentValidation;
using SocialBook.Application.Features.Queries;

namespace SocialBook.Application.Validators.Authors.AuthorReview
{
    public class GetAuthorReviewsByRatingQueryRequestValidator : AbstractValidator<GetAuthorReviewsByRatingQueryRequest>
    {
        public GetAuthorReviewsByRatingQueryRequestValidator()
        {
            RuleFor(x => x.Rating)
                .NotNull()
                .NotEmpty()
                .WithMessage("The rating cannot be null or empty!");

            RuleFor(x => x.Rating)
                .GreaterThan(0)
                .WithMessage("The rating must be grater than zero!");
        }
    }
}
