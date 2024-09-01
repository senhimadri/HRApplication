using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.UpdateDepartmentInfo;

public class UpdateDepartmentInfoCommand : IRequest<Unit>
{
    public UpdateDepartmentDto? DepartmentInfo { get; set; }
}
