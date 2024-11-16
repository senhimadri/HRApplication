using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Application.Results;
using MediatR;
using System.Data.Entity;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeeBasicInfoDetailsById;

public class GetEmployeeBasicInfoDetailsByIdRequestHandler(IUnitofWork unitOfWork) : IRequestHandler<GetEmployeeBasicInfoDetailsByIdRequest, GetEmployeeBasicInfoDto?>
{
    public readonly IUnitofWork _unitOfWork = unitOfWork;
    public async Task<GetEmployeeBasicInfoDto?> Handle(GetEmployeeBasicInfoDetailsByIdRequest request, CancellationToken cancellationToken)
    {
        var EmployeeDetails = await _unitOfWork.EmployeeBasicInfoRepository
                                            .GetEmployeeDetailsbyId(request.EmployeeId)
                                            .MapToEmployeeBasicInfoDto()
                                            .FirstOrDefaultAsync();
        return EmployeeDetails;
    }
}