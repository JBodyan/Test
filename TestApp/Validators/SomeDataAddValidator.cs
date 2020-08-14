using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.Dto;

namespace TestApp.Validators
{
    public class SomeDataAddValidator : AbstractValidator<SomeDataAddDto>
    {
        public SomeDataAddValidator()
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
