using HRApplication.Application.DataTransferObjects.CommonDTO;

namespace HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;

public class DepartmentInfoDto : BaseDto
{
    public string? DepartmentName { get; set; }
    public string? DepartmentCode { get; set; }
}
