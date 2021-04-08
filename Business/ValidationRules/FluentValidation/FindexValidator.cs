using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class FindexValidator : AbstractValidator<Findex>
    {
        public FindexValidator()
        {
            RuleFor(b => b.UserId).NotEmpty();
            RuleFor(b => b.FindexScore).ExclusiveBetween(0, 1901);
        }
    }
}
