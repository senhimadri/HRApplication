using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Exceptions;
using HRApplication.Application.Results;
using HRApplication.Domain.EmployeeManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.DeleteEmployeeBasicInfo;

public class DeleteEmployeeBasicInfoCommandHandler(IUnitofWork unitofWork) : IRequestHandler<DeleteEmployeeBasicInfoCommand, Result>
{
    private readonly IUnitofWork _unitofWork = unitofWork;

    public async Task<Result> Handle(DeleteEmployeeBasicInfoCommand request, CancellationToken cancellationToken)
    {
        var employeeDetails = await _unitofWork.EmployeeBasicInfoRepository.GetOne(request.EmployeeId);

        if (employeeDetails is null)
            return Errors.ContentNotFound;

        employeeDetails.IsActive = false;

        await _unitofWork.EmployeeBasicInfoRepository.ModifyOne(employeeDetails);
        await _unitofWork.SaveAsync();

        return Result.Success();
    }
}