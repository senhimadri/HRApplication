using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo.Validator;
using HRApplication.Application.Exceptions;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.CreateDepartmentInfo;

public class CreateDepartmentInfoCommandHandler : IRequestHandler<CreateDepartmentInfoCommand,long>
{
    private readonly IUnitofWork _unitofWork;
    public CreateDepartmentInfoCommandHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;

    public async Task<long> Handle(CreateDepartmentInfoCommand request, CancellationToken cancellationToken)
    {
        if (request.Department is null)
            throw new ArgumentNullException("API Body is null");


        var validator = new CreateDepartmentValidator(_unitofWork);
        var ValidationResult = await validator.ValidateAsync(request.Department);

        if (!ValidationResult.IsValid)
            throw new ValidationException(ValidationResult);

        var DepartmentInfo = DepartmentInfoMap.CreateDepartment(request.Department);

        DepartmentInfo = await _unitofWork.DepartmentInfoRepository.InsertOne(DepartmentInfo);

        await _unitofWork.SaveAsync();

        return DepartmentInfo.IntPrimaryId;
    }
}

