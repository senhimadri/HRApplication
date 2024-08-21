using FluentValidation;
using HRApplication.Application.Contracts.Parsistence;

namespace HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo.Validator;

public class IEmployeeBasicInfoDtoValidator : AbstractValidator<IEmployeeBasicInfoDto>
{
    private readonly IUnitofWork _unitOfWork;
    public IEmployeeBasicInfoDtoValidator(IUnitofWork unitOfWork)
    {
        _unitOfWork = unitOfWork;

        RuleFor(x => x.EmployeeName)
            .NotEmpty().NotNull().WithMessage("{PropertyName} shouldn't be empty")
            .Length(0, 100).WithMessage("Employee Name shouldn't be more than 100");

        RuleFor(x => x.EmployeeCode)
            .NotEmpty().NotNull().WithMessage("{PropertyName} shouldn't be empty")
            .Length(0, 50).WithMessage("Employee Code shouldn't be more than 50")
            .MustAsync(async (empCode, token) =>
            {
                var employeeCodeExit = await _unitOfWork
                        .EmployeeBasicInfoRepository
                        .GetCount(x => x.StrEmployeeCode == empCode);
                return employeeCodeExit == 0;
            }).WithMessage("Employee Code is already exit");

        RuleFor(x => x.DateOfBirth)
            .NotNull().NotEmpty().WithMessage("{PropertyName} shouldn't be empty");
    }
}
