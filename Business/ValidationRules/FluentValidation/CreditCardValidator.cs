using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CreditCardValidator : AbstractValidator<CreditCard>
    {
        public CreditCardValidator()
        {
            RuleFor(b => b.Name).MinimumLength(2).WithMessage("Kart adı minimum 2 karakter olabilir");
            RuleFor(b => b.CreditCardNumber).CreditCard().WithMessage("Geçerli bir kredi kartı numarası giriniz");
            RuleFor(b => b.CVV).Length(3).WithMessage("Geçerli bir Cvv bilgisi giriniz");
            RuleFor(b => b.UserId).NotEmpty();
        }
    }
}
