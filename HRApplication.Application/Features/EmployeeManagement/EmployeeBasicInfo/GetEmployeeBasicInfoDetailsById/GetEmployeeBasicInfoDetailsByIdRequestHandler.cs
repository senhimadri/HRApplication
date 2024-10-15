using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.Exceptions;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeeBasicInfoDetailsById;

public class GetEmployeeBasicInfoDetailsByIdRequestHandler : IRequestHandler<GetEmployeeBasicInfoDetailsByIdRequest, GetEmployeeBasicInfoDto?>
{
    public readonly IUnitofWork _unitOfWork;
    public GetEmployeeBasicInfoDetailsByIdRequestHandler(IUnitofWork unitOfWork) => _unitOfWork = unitOfWork;
    public async Task<GetEmployeeBasicInfoDto?> Handle(GetEmployeeBasicInfoDetailsByIdRequest request, CancellationToken cancellationToken)
    {
        var EmployeeDetails = await _unitOfWork.EmployeeBasicInfoRepository.GetEmployeeDetailsbyId(request.EmployeeId);

        return EmployeeBasicInfoMap.GetEmployee(EmployeeDetails);
    }
}