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

        var _existingEmployee = await _unitofWork.EmployeeBasicInfoRepository
                                    .GetOne(request.employeeBasicInfo.PrimaryId);

        if (_existingEmployee is null)
            throw new NotFoundException("Employee", request.employeeBasicInfo.PrimaryId);

        _existingEmployee = EmployeeBasicInfoMap.UpdateEmployee(request.employeeBasicInfo, _existingEmployee);


        await _unitofWork.EmployeeBasicInfoRepository.ModifyOne(_existingEmployee);
        await _unitofWork.SaveAsync();

        return Unit.Value;
    }
}