using FluentValidation;
using Application.Validation.Data;
using Application.DTOs;

namespace Application.Validation
{
	public class CreateJobRequestValidator : AbstractValidator<CreateJobRequest>
	{
		public CreateJobRequestValidator()
		{
			RuleFor(c => c.JobTitle).NotEmpty();
			RuleFor(c => c.Employer).NotEmpty();
			RuleFor(c => c.City).NotEmpty();
			RuleFor(c => c.State.ToUpper()).NotEmpty().Must(IsAState);
			RuleFor(c => c.Status.ToUpper()).NotEmpty().Must(IsValidStatus);
			RuleFor(c => c.Amenities).NotNull();

		}

		private bool IsAState(string state)
		{
			return States.Abbreviations.Contains(state) || States.Names.Contains(state);
		}

		private bool IsValidStatus(string status)
		{
			return Statuses.Names.Contains(status);
		}

	}
}
