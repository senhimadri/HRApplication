using HRApplication.Application.DataTransferObjects.CommonDTO;
using HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo;

namespace HRApplication.Application.DataTransferObjects.LeaveManagement;

public class UpdateEmployeeBasicInfoDto :BaseDto, IEmployeeBasicInfoDto
{
    public string? EmployeeName { get; set; }
    public string? EmployeeCode { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public long DepartmentId { get; set; }
    public long DesignationId { get; set; }
    public long GenderId { get; set; }
    public long ReligionId { get; set; }
}

