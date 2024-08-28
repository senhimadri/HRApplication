using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeesBasicInfoList;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.GetDepartmentInfoList;

public class GetDepartmentInfoListRequest : IRequest<List<DepartmentInfoDto>>
{
    public string? SearchText { get; set; }
}
