using HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeesBasicInfoList;

public class GetEmployeesBasicInfoListRequest : IRequest<List<GetEmployeeBasicInfoLandingDto>>
{
    public ParamsEmployeeBasicInfoLandingDto? LandingParameeter { get; set; }
}