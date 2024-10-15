using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Exceptions;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Application.Results;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.CreateEmployeebasicInfo;

public class CreateEmployeeBasicInfoCommandHandler : IRequestHandler<CreateEmployeeBasicInfoCommand, Result>
{
    private readonly IUnitofWork _unitofWork;

    public CreateEmployeeBasicInfoCommandHandler(IUnitofWork unitofWork)
                                        => _unitofWork = unitofWork;

    public async Task<Result> Handle(CreateEmployeeBasicInfoCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateEmployeeBasicInfoDtoValidator(_unitofWork);
        var validationResult = await validator.ValidateAsync(request.employeeBasicInfo);

        if (!validationResult.IsValid)
            return default;
           

        var employeeBasicInfo = EmployeeBasicInfoMap.CreateEmployee(request.employeeBasicInfo);

        employeeBasicInfo = await _unitofWork.EmployeeBasicInfoRepository.InsertOne(employeeBasicInfo);

        await _unitofWork.SaveAsync();

        return Result.Success();
    }
}