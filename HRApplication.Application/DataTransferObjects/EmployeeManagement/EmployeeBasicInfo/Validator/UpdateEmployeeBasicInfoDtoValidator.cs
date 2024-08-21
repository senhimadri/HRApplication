using FluentValidation;
using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo.Validator;
using HRApplication.Application.DataTransferObjects.LeaveManagement;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.CreateEmployeebasicInfo;

public class UpdateEmployeeBasicInfoDtoValidator : AbstractValidator<UpdateEmployeeBasicInfoDto>
{
    private readonly IUnitofWork _unitOfWork;
    public UpdateEmployeeBasicInfoDtoValidator(IUnitofWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        Include(new IEmployeeBasicInfoDtoValidator(_unitOfWork));

        RuleFor(p => p.PrimaryId).NotNull().WithMessage("{PropertyName} must be present");
    }
}