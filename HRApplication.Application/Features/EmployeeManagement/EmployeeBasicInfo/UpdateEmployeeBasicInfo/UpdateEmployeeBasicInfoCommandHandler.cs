using FluentValidation;
using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Exceptions;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.CreateEmployeebasicInfo;
using HRApplication.Application.Helper;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Application.Results;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.UpdateEmployeeBasicInfo;

public class UpdateEmployeeBasicInfoCommandHandler(IUnitofWork unitofWork) : IRequestHandler<UpdateEmployeeBasicInfoCommand, Result>
{
    private readonly IUnitofWork _unitofWork = unitofWork;

    public async Task<Result> Handle(UpdateEmployeeBasicInfoCommand request, CancellationToken cancellationToken)
    {
        if (request.employeeBasicInfo is null)
            return Errors.ContentNotFound;

        var validationResult = await new UpdateEmployeeBasicInfoDtoValidator(_unitofWork)
                       .ValidateAndReturnResultAsync(request.employeeBasicInfo);

        if (!validationResult.IsValid)
            return Result.ValidationFailure(validationResult.ToValidationErrorList());

        var _existingEmployee = await _unitofWork.EmployeeBasicInfoRepository
                                    .GetOne(request.employeeBasicInfo.PrimaryId);

        if (_existingEmployee is null)
            return Errors.ContentNotFound;

        _existingEmployee.MapWithUpdateEmployeeDto(request.employeeBasicInfo);

        await _unitofWork.EmployeeBasicInfoRepository.ModifyOne(_existingEmployee);
        await _unitofWork.SaveAsync();

        return Result.Success();
    }
}