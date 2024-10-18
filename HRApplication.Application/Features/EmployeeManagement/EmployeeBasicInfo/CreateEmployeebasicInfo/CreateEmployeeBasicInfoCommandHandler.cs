using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Helper;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Application.Results;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.CreateEmployeebasicInfo;

public class CreateEmployeeBasicInfoCommandHandler : IRequestHandler<CreateEmployeeBasicInfoCommand, Result>
{
    private readonly IUnitofWork _unitofWork;
    public CreateEmployeeBasicInfoCommandHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;

    public async Task<Result> Handle(CreateEmployeeBasicInfoCommand request, CancellationToken cancellationToken)
    {
        if (request.employeeBasicInfo is null)
            return Errors.ContentNotFound;

        var validationResult = await new CreateEmployeeBasicInfoDtoValidator(_unitofWork)
                               .ValidateAndReturnResultAsync(request.employeeBasicInfo);

        if (!validationResult.IsValid)
            return Result.ValidationFailure(validationResult.ToValidationErrorList());

        var employeeBasicInfo = request.employeeBasicInfo.MapToEmployeeEntity();

        employeeBasicInfo = await _unitofWork.EmployeeBasicInfoRepository.InsertOne(employeeBasicInfo);

        await _unitofWork.SaveAsync();
        return Result.Success();
    }
}