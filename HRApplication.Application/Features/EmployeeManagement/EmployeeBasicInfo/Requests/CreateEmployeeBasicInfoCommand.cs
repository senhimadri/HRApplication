using HRApplication.Application.DataTransferObjects.LeaveManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.Requests;

public class CreateEmployeeBasicInfoCommand : IRequest<long>
{
    public CreateEmployeeBasicInfoDto employeeBasicInfo { get; set; } = new CreateEmployeeBasicInfoDto();
}