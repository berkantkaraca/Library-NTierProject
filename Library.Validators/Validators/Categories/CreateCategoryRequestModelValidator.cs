using FluentValidation;
using Library.Validators.RequestModels.Categories;

namespace Library.Validators.Validators.Categories
{
    public class CreateCategoryRequestModelValidator : AbstractValidator<CreateCategoryRequestModel>
    {
        public CreateCategoryRequestModelValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("CategoryName boþ olamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description boþ olamaz");
        }
    }
}
