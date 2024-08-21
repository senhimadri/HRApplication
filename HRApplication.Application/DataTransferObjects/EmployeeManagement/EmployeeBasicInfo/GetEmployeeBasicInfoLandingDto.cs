using HRApplication.Application.DataTransferObjects.CommonDTO;

namespace HRApplication.Application.DataTransferObjects.LeaveManagement;

public class GetEmployeeBasicInfoLandingDto : BaseDto
{
    public string? EmployeeName { get; set; }
    public string? EmployeeCode { get; set; }
    public DateTime? DateOfBirth { get; set; }

    public string? Department { get; set; }
    public string? Designation { get; set; }
    public string? Gender { get; set; }
    public string? Religion { get; set; }
}

