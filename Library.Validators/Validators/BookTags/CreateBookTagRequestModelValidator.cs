using FluentValidation;
using Library.Validators.RequestModels.BookTags;

namespace Library.Validators.Validators.BookTags
{
    public class CreateBookTagRequestModelValidator : AbstractValidator<CreateBookTagRequestModel>
    {
        public CreateBookTagRequestModelValidator()
        {
            RuleFor(x => x.BookId).GreaterThan(0).WithMessage("BookId must be greater than 0");
            RuleFor(x => x.TagId).GreaterThan(0).WithMessage("TagId must be greater than 0");
        }
    }
}
