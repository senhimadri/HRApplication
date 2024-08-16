namespace HRApplication.Application.DataTransferObjects.LeaveManagement;

public class CreateEmployeeBasicInfoDto 
{
    public string? StrEmployeeName { get; set; }
    public string? StrEmployeeCode { get; set; }
    public DateTime? DteDateOfBirth { get; set; }
    public long IntDepartmentId { get; set; }
    public long IntDesignationId { get; set; }
    public long IntGenderId { get; set; }
    public long IntReligionId { get; set; }
}

