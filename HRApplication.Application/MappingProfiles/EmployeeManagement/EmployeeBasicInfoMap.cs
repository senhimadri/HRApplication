using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Domain.EmployeeManagement;

namespace HRApplication.Application.MappingProfiles.EmployeeManagement;

public static class EmployeeBasicInfoMap
{
    public static TblEmployeeBasicInfo mapper(CreateEmployeeBasicInfoDto data)
    {
        return new TblEmployeeBasicInfo()
        {
            StrEmployeeName =data.StrEmployeeName,
            StrEmployeeCode =data.StrEmployeeCode,
            DteDateOfBirth =data.DteDateOfBirth,
            IntDepartmentId =data.IntDepartmentId,
            IntDesignationId =data.IntDesignationId,
            IntGenderId =data.IntGenderId,
            IntReligionId =data.IntReligionId
        };
    }
}