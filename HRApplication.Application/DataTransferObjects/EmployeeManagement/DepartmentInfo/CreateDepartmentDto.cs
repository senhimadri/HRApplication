namespace HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;

public class CreateDepartmentDto : IDepartmentDto
{
    public string? DepartmentName { get; set; }
    public string? DepartmentCode { get; set; }
}