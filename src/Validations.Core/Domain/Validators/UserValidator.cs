﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Validations.Core.Domain.Entities;

namespace Validations.Core.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.PhoneNumber)
                .NotEmpty();

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();
        }
    }
}