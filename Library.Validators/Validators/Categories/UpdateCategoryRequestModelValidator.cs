using FluentValidation;
using Library.Validators.RequestModels.Categories;

namespace Library.Validators.Validators.Categories
{
    public class UpdateCategoryRequestModelValidator : AbstractValidator<UpdateCategoryRequestModel>
    {
        public UpdateCategoryRequestModelValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Geçersiz Id");
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("CategoryName boþ olamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description boþ olamaz");
        }
    }
}
