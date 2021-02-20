using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=>c.Description).MinimumLength(3);
            RuleFor(c=>c.DailyPrice).GreaterThanOrEqualTo(100).WithMessage("Günlük ücret minimum 1ooTL olmalıdır.");
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.ModelYear).NotEmpty();
        }
    }
}
