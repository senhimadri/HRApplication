using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.DeleteDepartmentInfo;

public class DeleteDepartmentInfoCommand : IRequest<Unit>
{
    public long PrimaryId { get; set; }
}
