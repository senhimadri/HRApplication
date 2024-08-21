using HRApplication.Application.DataTransferObjects.CommonDTO;
namespace HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo;

public class ParamsEmployeeBasicInfoLandingDto : CommonPaginationDto
{
    public string? SearchText { get; set; }
    public List<long>? DepartmentIdList { get; set; }
    public List<long>? DesignationIdList { get; set; }
    public List<long>? GenderIdList { get; set; }
    public List<long>? ReligionIdList { get; set; }

}
