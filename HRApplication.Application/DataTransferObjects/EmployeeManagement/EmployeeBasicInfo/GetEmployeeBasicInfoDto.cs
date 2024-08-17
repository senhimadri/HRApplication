namespace HRApplication.Application.DataTransferObjects.LeaveManagement;

public class GetEmployeeBasicInfoDto
{
    public long IntPrimaryId { get; set; }
    public string? StrEmployeeName { get; set; }
    public string? StrEmployeeCode { get; set; }
    public DateTime? DteDateOfBirth { get; set; }
    public string? StrDepartment { get; set; }
    public string? StrDesignation { get; set; }
    public string? StrGender { get; set; }
    public string? StrReligionId { get; set; }
}

