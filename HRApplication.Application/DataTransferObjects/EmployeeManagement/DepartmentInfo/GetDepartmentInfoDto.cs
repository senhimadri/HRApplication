using HRApplication.Application.DataTransferObjects.CommonDTO;

namespace HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;

public class GetDepartmentInfoDto : BaseDto
{
    public string? DepartmentName { get; set; }
    public string? DepartmentCode { get; set; }
}