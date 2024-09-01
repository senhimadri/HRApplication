using FluentValidation;
using HRApplication.Application.Contracts.Parsistence;

namespace HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo.Validator;

public class IDepartmentValidator : AbstractValidator<IDepartmentDto>
{

    private readonly IUnitofWork _unitOfWork;

    public IDepartmentValidator(IUnitofWork unitOfWork)
    {
        _unitOfWork = unitOfWork;

        RuleFor(x => x.DepartmentName)
            .NotNull().NotEmpty().WithMessage("{PropertyName} shouldn't be empty")
            .Length(0, 100).WithMessage("Department Name shouldn't be more than 100")
            .MustAsync(async (deptName, token) =>
            {
                var deptNameExist = await _unitOfWork
                        .DepartmentInfoRepository
                        .IsExist(x => x.StrDepartmentName == deptName);
                return !deptNameExist;
            }).WithMessage("Department is already exit");

        RuleFor(x => x.DepartmentCode)
            .NotNull().NotEmpty().WithMessage("{PropertyName} shouldn't be empty.")
            .Length(0, 100).WithMessage("Department Code shouldn't be more than 100")
            .MustAsync(async (deptCode, token) =>
            {
                var deptCodeExit = await _unitOfWork
                                .DepartmentInfoRepository
                                .IsExist(x => x.StrDepartmentCode == deptCode);
                return !deptCodeExit;
            }).WithMessage("Department Code is already exist.");
    }
}

public class CreateDepartmentValidator : AbstractValidator<CreateDepartmentDto>
{
    private readonly IUnitofWork _unitofWork;
    public CreateDepartmentValidator(IUnitofWork unitofWork)
    {
        _unitofWork = unitofWork;
        Include(new IDepartmentValidator(_unitofWork));
    }
}

public class UpdateDepartmentValidator : AbstractValidator<UpdateDepartmentDto>
{

    private readonly IUnitofWork _unitofWork;
    public UpdateDepartmentValidator(IUnitofWork unitofWork)
    {
        _unitofWork = unitofWork;
        Include(new IDepartmentValidator(_unitofWork));
        RuleFor(x => x.PrimaryId)
            .NotNull().NotEqual(0).WithMessage("{PropertyName} must be present");
    }
}