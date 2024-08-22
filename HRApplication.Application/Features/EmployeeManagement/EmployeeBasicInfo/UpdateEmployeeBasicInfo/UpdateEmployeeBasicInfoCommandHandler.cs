using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Exceptions;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.CreateEmployeebasicInfo;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.UpdateEmployeeBasicInfo;

public class UpdateEmployeeBasicInfoCommandHandler : IRequestHandler<UpdateEmployeeBasicInfoCommand, Unit>
{
    private readonly IUnitofWork _unitofWork;

    public UpdateEmployeeBasicInfoCommandHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;

    public async Task<Unit> Handle(UpdateEmployeeBasicInfoCommand request, CancellationToken cancellationToken)
    {
        var validator = new UpdateEmployeeBasicInfoDtoValidator(_unitofWork);

        var validationResult = await validator.ValidateAsync(request.employeeBasicInfo);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult);

        var employeeBasicInfo = EmployeeBasicInfoMap.UpdateEmployee(request.employeeBasicInfo);
        await _unitofWork.EmployeeBasicInfoRepository.ModifyOne(employeeBasicInfo);
        await _unitofWork.SaveAsync();

        return Unit.Value;
    }
}