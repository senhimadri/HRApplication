using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;
using HRApplication.Domain.EmployeeManagement;

namespace HRApplication.Application.MappingProfiles.EmployeeManagement;

public static class DepartmentInfoMap
{
    public static TblDepartmentInfo CreateDepartment(CreateDepartmentDto data)
    {

        return new TblDepartmentInfo
        {
            StrDepartmentName= data.DepartmentName,
            StrDepartmentCode = data.DepartmentCode
        }
    }
}