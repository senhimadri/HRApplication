using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.CreateDepartmentInfo;

public class CreateDepartmentInfoCommand : IRequest<long>
{
    public CreateDepartmentDto? Department { get; set; }
}

