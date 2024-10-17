using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.Exceptions;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Application.Results;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeeBasicInfoDetailsById;

public class GetEmployeeBasicInfoDetailsByIdRequestHandler : IRequestHandler<GetEmployeeBasicInfoDetailsByIdRequest, Result<GetEmployeeBasicInfoDto>>
{
    public readonly IUnitofWork _unitOfWork;
    public GetEmployeeBasicInfoDetailsByIdRequestHandler(IUnitofWork unitOfWork) => _unitOfWork = unitOfWork;
    public async Task<Result<GetEmployeeBasicInfoDto>> Handle(GetEmployeeBasicInfoDetailsByIdRequest request, CancellationToken cancellationToken)
    {
        var EmployeeDetails = await _unitOfWork.EmployeeBasicInfoRepository.GetEmployeeDetailsbyId(request.EmployeeId);

        if (EmployeeDetails is null)
            return Errors.ContentNotFound;

        return EmployeeBasicInfoMap.GetEmployee(EmployeeDetails);
    }
}