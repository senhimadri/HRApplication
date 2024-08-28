using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo.Validator;
using HRApplication.Application.Exceptions;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.UpdateDepartmentInfo;

public class UpdateDepartmentInfoCommandHandler : IRequestHandler<UpdateDepartmentInfoCommand, Unit>
{

    private readonly IUnitofWork _unitofWork;
    public UpdateDepartmentInfoCommandHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;

    public async Task<Unit> Handle(UpdateDepartmentInfoCommand request, CancellationToken cancellationToken)
    {
        if (request.DepartmentInfo is null)
            throw new ArgumentNullException("API Body is null");

        var Validator = new UpdateDepartmentValidator(_unitofWork);
        var ValidationResult = await Validator.ValidateAsync(request.DepartmentInfo);

        if (!ValidationResult.IsValid)
            throw new ValidationException(ValidationResult);


        var DepartmentInformation = DepartmentInfoMap.UpdateDepartment(request.DepartmentInfo);

        await _unitofWork.DepartmentInfoRepository.ModifyOne(DepartmentInformation);
        await _unitofWork.SaveAsync();

        return Unit.Value;
    }
}