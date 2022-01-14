using CodeChallenge.Shared.Dtos;
using FluentValidation;

namespace CodeChallenge.Server.Validators
{
    public class ShiftValidator : AbstractValidator<AddShiftDto>
    {
        public ShiftValidator()
        {
            RuleFor(c => c.EmployeeId).NotEmpty();
            RuleFor(c => c.ShiftTypeId).NotEmpty();
            RuleFor(c => c.StartDate).NotEmpty();
            RuleFor(c => c.EndDate).NotEmpty();
            RuleFor(c => c.EndDate).GreaterThan(c=>c.StartDate).WithMessage("End date must be greater than start date");
        }
    }
}
