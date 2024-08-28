using MediatR;
namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.DeleteEmployeeBasicInfo;

public class DeleteEmployeeBasicInfoCommand  : IRequest<Unit>
{
    public long EmployeeId { get; set; }
}