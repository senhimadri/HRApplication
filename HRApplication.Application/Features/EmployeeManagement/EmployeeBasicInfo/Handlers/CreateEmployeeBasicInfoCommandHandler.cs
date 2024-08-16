using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.DataTransferObjects.LeaveManagement.Validator;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.Requests;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Domain.EmployeeManagement;
using MediatR;
using System.IO.MemoryMappedFiles;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.Handlers;

public class CreateEmployeeBasicInfoCommandHandler : IRequestHandler<CreateEmployeeBasicInfoCommand, long>
{
    private readonly IUnitofWork _unitofWork;

    public CreateEmployeeBasicInfoCommandHandler(IUnitofWork unitofWork) 
                                        => _unitofWork = unitofWork;

    public async Task<long> Handle(CreateEmployeeBasicInfoCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateEmployeeBasicInfoDtoValidator(_unitofWork);
        var validationResult = await validator.ValidateAsync(request.employeeBasicInfo);

        if (!validationResult.IsValid)
            throw new Exception(validationResult.ToString());

        var employeeBasicInfo = EmployeeBasicInfoMap.mapper(request.employeeBasicInfo);

        employeeBasicInfo = await _unitofWork.EmployeeBasicInfoRepository.InsertOne(employeeBasicInfo);

        await _unitofWork.SaveAsync();

        return employeeBasicInfo.IntPrimaryId;
    }
}