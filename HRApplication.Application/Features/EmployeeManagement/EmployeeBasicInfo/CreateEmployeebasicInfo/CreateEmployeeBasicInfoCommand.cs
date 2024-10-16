using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.Results;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.CreateEmployeebasicInfo;

public class CreateEmployeeBasicInfoCommand : IRequest<Result>
{
    public CreateEmployeeBasicInfoDto? employeeBasicInfo { get; set; }
}