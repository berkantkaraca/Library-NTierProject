using FluentValidation;
using Library.Validators.RequestModels.Authors;

namespace Library.Validators.Validators.Authors
{
    public class UpdateAuthorRequestModelValidator : AbstractValidator<UpdateAuthorRequestModel>
    {
        public UpdateAuthorRequestModelValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id must be greater than 0");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName cannot be empty");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName cannot be empty");
        }
    }
}
