using HRApplication.Application.Results;
using MediatR;
namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.DeleteEmployeeBasicInfo;

public class DeleteEmployeeBasicInfoCommand : IRequest<Result>
{
    public long EmployeeId { get; set; }
}