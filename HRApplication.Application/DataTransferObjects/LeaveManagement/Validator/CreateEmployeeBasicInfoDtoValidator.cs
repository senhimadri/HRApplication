using FluentValidation;

namespace HRApplication.Application.DataTransferObjects.LeaveManagement.Validator;

public class CreateEmployeeBasicInfoDtoValidator : AbstractValidator<CreateEmployeeBasicInfoDto>
{
	public CreateEmployeeBasicInfoDtoValidator()
	{
		RuleFor(x => x.StrEmployeeName)
			.Length(0, 100).WithErrorCode("{PropertyName} ");
	}
}


//public string? StrEmployeeName { get; set; }
//public string? StrEmployeeCode { get; set; }
//public DateTime? DteDateOfBirth { get; set; }
//public long IntDepartmentId { get; set; }
//public long IntDesignationId { get; set; }
//public long IntGenderId { get; set; }
//public long IntReligionId { get; set; }