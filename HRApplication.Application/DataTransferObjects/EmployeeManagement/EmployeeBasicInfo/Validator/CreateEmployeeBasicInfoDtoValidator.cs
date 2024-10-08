using FluentValidation;
using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Contracts.Parsistence.EmployeeManagement;
using HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo.Validator;
using HRApplication.Application.DataTransferObjects.LeaveManagement;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.CreateEmployeebasicInfo;

public class CreateEmployeeBasicInfoDtoValidator : AbstractValidator<CreateEmployeeBasicInfoDto>
{
    private readonly IUnitofWork _unitOfWork;
    public CreateEmployeeBasicInfoDtoValidator(IUnitofWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        Include(new IEmployeeBasicInfoDtoValidator(_unitOfWork));
    }
}
