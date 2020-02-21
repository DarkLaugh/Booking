using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.WebApi.ViewModels;
using FluentValidation;

namespace Booking.WebApi.Validation
{
    public class ResortValidator : AbstractValidator<ResortViewModel>
    {
        public ResortValidator()
        {
            RuleFor(x => x.Id)
                .NotNull();

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Please provide a valid name for the resort.");

            RuleFor(x => x.Price)
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("You must enter a valid price for your resort.");

            RuleFor(x => x.Rating)
                .Must(rating => rating >= 0 && rating <= 5)
                .WithMessage("Please provide a valid rating for your resort.");

            RuleFor(x => x.ResortTypeId)
                .NotNull()
                .Must(rt => rt >= 1 && rt <= 3)
                .WithMessage("Please provide a valid resort type.");

            RuleFor(x => x.Capacity)
                .NotEmpty()
                .GreaterThan((short)0)
                .WithMessage("Please specify the capacity of your resort.");

            RuleFor(x => x.Rooms)
                .NotEmpty()
                .GreaterThan((short)0)
                .WithMessage("Please specify the number of rooms in your resort.");
        }
    }
}
