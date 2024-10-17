using HRApplication.Application.DataTransferObjects.LeaveManagement;
using MediatR;
using HRApplication.Application.Results;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.UpdateEmployeeBasicInfo;

public class UpdateEmployeeBasicInfoCommand : IRequest<Result>
{
    public UpdateEmployeeBasicInfoDto? employeeBasicInfo { get; set; }
}