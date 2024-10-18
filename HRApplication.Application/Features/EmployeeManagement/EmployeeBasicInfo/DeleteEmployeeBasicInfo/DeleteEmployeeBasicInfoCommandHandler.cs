using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Exceptions;
using HRApplication.Application.Results;
using HRApplication.Domain.EmployeeManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.DeleteEmployeeBasicInfo;

public class DeleteEmployeeBasicInfoCommandHandler : IRequestHandler<DeleteEmployeeBasicInfoCommand, Result>
{
    private readonly IUnitofWork _unitofWork;
    public DeleteEmployeeBasicInfoCommandHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;

    public async Task<Result> Handle(DeleteEmployeeBasicInfoCommand request, CancellationToken cancellationToken)
    {
        var EmployeeDetails = await _unitofWork.EmployeeBasicInfoRepository.GetOne(request.EmployeeId);

        if (EmployeeDetails is null)
            return Errors.ContentNotFound;

        EmployeeDetails.IsActive = false;

        await _unitofWork.EmployeeBasicInfoRepository.ModifyOne(EmployeeDetails);
        await _unitofWork.SaveAsync();

        return Result.Success();
    }
}