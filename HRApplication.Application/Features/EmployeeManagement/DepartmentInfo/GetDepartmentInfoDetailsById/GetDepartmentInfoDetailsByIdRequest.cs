using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.GetDepartmentInfoDetailsById;

public class GetDepartmentInfoDetailsByIdRequest : IRequest<DepartmentInfoDto>
{
    public long DepartmentId { get; set; }
}
