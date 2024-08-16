using FluentValidation;
using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Contracts.Parsistence.EmployeeManagement;

namespace HRApplication.Application.DataTransferObjects.LeaveManagement.Validator;

public class CreateEmployeeBasicInfoDtoValidator : AbstractValidator<CreateEmployeeBasicInfoDto>
{
	private readonly IUnitofWork _unitOfWork ;
	public CreateEmployeeBasicInfoDtoValidator(IUnitofWork unitOfWork)
	{
		_unitOfWork = unitOfWork;

        RuleFor(x => x.StrEmployeeName)
			.NotEmpty().NotNull().WithMessage("{PropertyName} shouldn't be empty")
			.Length(0, 100).WithMessage("Employee Name shouldn't be more than 100");

		RuleFor(x => x.StrEmployeeCode)
            .NotEmpty().NotNull().WithMessage("{PropertyName} shouldn't be empty")
            .Length(0, 50).WithMessage("Employee Code shouldn't be more than 50")
			.MustAsync(async (empCode, token) =>
			{
				var employeeCodeExit = await _unitOfWork
						.EmployeeBasicInfoRepository
						.GetCount(x => x.StrEmployeeCode== empCode);
				return employeeCodeExit > 0;
			}).WithMessage("Employee Code is already exit");

		RuleFor(x => x.DteDateOfBirth)
			.NotNull().NotEmpty().WithMessage("{PropertyName} shouldn't be empty");
    }
}


//public string? StrEmployeeName { get; set; }
//public string? StrEmployeeCode { get; set; }
//public DateTime? DteDateOfBirth { get; set; }
//public long IntDepartmentId { get; set; }
//public long IntDesignationId { get; set; }
//public long IntGenderId { get; set; }
//public long IntReligionId { get; set; }