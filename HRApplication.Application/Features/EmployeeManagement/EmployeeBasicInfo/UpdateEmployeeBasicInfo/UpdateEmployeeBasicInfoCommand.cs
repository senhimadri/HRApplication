using HRApplication.Application.DataTransferObjects.LeaveManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.UpdateEmployeeBasicInfo;

public class UpdateEmployeeBasicInfoCommand : IRequest<Unit>
{
    public UpdateEmployeeBasicInfoDto employeeBasicInfo { get; set; } = new UpdateEmployeeBasicInfoDto();
}