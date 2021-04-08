using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class PaymentValidator : AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(b => b.ProcessDate).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.CarId).NotEmpty();
        }
    }
}
