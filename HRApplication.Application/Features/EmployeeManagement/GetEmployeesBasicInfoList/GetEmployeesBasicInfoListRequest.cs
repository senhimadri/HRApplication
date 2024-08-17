using HRApplication.Application.DataTransferObjects.CommonDTO;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.GetEmployeesBasicInfoList;

public class GetEmployeesBasicInfoListRequest : CommonPaginationDto, IRequest<List<GetEmployeeBasicInfoDto>>
{
    public string? SearchText { get; set; }
    public long DepartmentId { get; set; }
    public long DesignationId { get; set; }
    public long GenderId { get; set; }
    public long ReligionId { get; set; }
}