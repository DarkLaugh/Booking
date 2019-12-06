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
                .NotNull();

            RuleFor(x => x.LastName)
                .NotNull();

            RuleFor(x => x.Age)
                .Must(number => number >= 18)
                .WithMessage("You must be 18 years old or more to be a client.");
        }
    }
}
