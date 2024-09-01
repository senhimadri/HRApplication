using HRApplication.Application.DataTransferObjects.CommonDTO;

namespace HRApplication.Application.DataTransferObjects.LeaveManagement;

public class GetEmployeeBasicInfoDto : BaseDto
{
    public string? EmployeeName { get; set; }
    public string? EmployeeCode { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public long DepartmentId { get; set; }
    public string? Department { get; set; }

    public long DesignationId { get; set; }
    public string? Designation { get; set; }

    public long GenderId { get; set; }
    public string? Gender { get; set; }

    public long ReligionId { get; set; }
    public string? Religion { get; set; }
}

