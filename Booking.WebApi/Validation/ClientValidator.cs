using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Booking.WebApi.ViewModels;

namespace Booking.WebApi.Validation
{
    public class ClientValidator : AbstractValidator<ClientViewModel>
    {
        public ClientValidator()
        {
            RuleFor(x => x.Id)
                .NotNull();

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("You didn't enter a valid first name.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("You didn't enter a valid last name.");

            RuleFor(x => x.Age)
                .Must(number => number >= 18)
                .WithMessage("You must be 18 years old or more to be a client.");

            RuleFor(x => x.ClientTypeId)
                .NotNull()
                .Must(ct => ct >= 1 && ct <= 3)
                .WithMessage("Please select a valid client type.");
        }
    }
}
