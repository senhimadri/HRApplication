using HRApplication.Application.DataTransferObjects.CommonDTO;
using HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.Results;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeesBasicInfoList;

public class GetEmployeesBasicInfoListRequest : IRequest<Result<GetLandingPagination<GetEmployeeBasicInfoLandingDto>>>
{
    public ParamsEmployeeBasicInfoLandingDto? LandingParameeter { get; set; }
}