using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;
using HRApplication.Domain.EmployeeManagement;

namespace HRApplication.Application.MappingProfiles.EmployeeManagement;

public static class DepartmentInfoMap
{
    public static TblDepartmentInfo CreateDepartment(CreateDepartmentDto data)
    {
        return new TblDepartmentInfo
        {
            StrDepartmentName = data.DepartmentName,
            StrDepartmentCode = data.DepartmentCode
        };
    }

    public static TblDepartmentInfo UpdateDepartment(UpdateDepartmentDto data)
    {
        return new TblDepartmentInfo
        {
            IntPrimaryId = data.PrimaryId,
            StrDepartmentName = data.DepartmentName,
            StrDepartmentCode = data.DepartmentCode
        };
    }

    public static List<DepartmentInfoDto> DepartmentInfoList(List<TblDepartmentInfo> data)
    {
        return data.Select(DepartmentInfo).ToList();
    }

    public static DepartmentInfoDto DepartmentInfo(TblDepartmentInfo data)
    {
        return new DepartmentInfoDto
        {
            PrimaryId = data.IntPrimaryId,
            DepartmentName = data.StrDepartmentName,
            DepartmentCode = data.StrDepartmentCode
        };
    }
}