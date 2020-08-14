using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.Dto;
using FluentValidation;

namespace TestApp.Validators
{
    public class SomeDataUpdateValidator : AbstractValidator<SomeDataUpdateDto>
    {
        public SomeDataUpdateValidator()
        {
            RuleFor(x => x.Code)
                .Matches(@"\d{3}")
                .NotEmpty();

            RuleFor(x => x.Name)
                .MinimumLength(3)
                .MaximumLength(20)
                .NotEmpty();
        }
    }
}
