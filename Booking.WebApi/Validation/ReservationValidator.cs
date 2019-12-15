using Booking.WebApi.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.WebApi.Validation
{
    public class ReservationValidator : AbstractValidator<ReservationViewModel>
    {
        public ReservationValidator()
        {
            RuleFor(x => x.Id)
                .NotNull();

            RuleFor(x => x.ClientId)
                .NotNull()
                .GreaterThan((byte)0)
                .WithMessage("Please select a valid client for the reservation.");

            RuleFor(x => x.ResortId)
                .NotNull()
                .GreaterThan((byte)0)
                .WithMessage("Please select a valid resort for the reservation.");
        }
    }
}
