using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.Results;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeeBasicInfoDetailsById;

public class GetEmployeeBasicInfoDetailsByIdRequest : IRequest<GetEmployeeBasicInfoDto?>
{
    public long EmployeeId { get; set; }
}