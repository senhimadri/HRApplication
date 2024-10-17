using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Domain.EmployeeManagement;

namespace HRApplication.Application.MappingProfiles.EmployeeManagement;

public static class EmployeeBasicInfoMap
{
    public static TblEmployeeBasicInfo CreateEmployee(CreateEmployeeBasicInfoDto data)
    {
        return new TblEmployeeBasicInfo()
        {

            StrEmployeeName = data.EmployeeName,
            StrEmployeeCode = data.EmployeeCode,
            DteDateOfBirth = data.DateOfBirth,
            IntDepartmentId = data.DepartmentId,
            IntDesignationId = data.DesignationId,
            IntGenderId = data.GenderId,
            IntReligionId = data.ReligionId
        };
    }

    public static TblEmployeeBasicInfo UpdateEmployee(UpdateEmployeeBasicInfoDto input, TblEmployeeBasicInfo existing)
    {
        existing.StrEmployeeName = input.EmployeeName;
        existing.StrEmployeeCode = input.EmployeeCode;
        existing.DteDateOfBirth = input.DateOfBirth;
        existing.IntDepartmentId = input.DepartmentId;
        existing.IntDesignationId = input.DesignationId;
        existing.IntGenderId = input.GenderId;
        existing.IntReligionId = input.ReligionId;

        return existing;
    }

    public static GetEmployeeBasicInfoDto GetEmployee(TblEmployeeBasicInfo data)
    {
        return new GetEmployeeBasicInfoDto()
        {
            PrimaryId = data.IntPrimaryId,
            EmployeeName = data.StrEmployeeName,
            EmployeeCode = data.StrEmployeeCode,
            DateOfBirth = data.DteDateOfBirth,

            DepartmentId = data.IntDepartmentId,
            Department = data.TblDepartmentInfo?.StrDepartmentName,

            DesignationId = data.IntDesignationId,
            Designation = data.TblDesignationInfo?.StrDesignationName,

            GenderId = data.IntGenderId,
            Gender = data.TblGenderInfo?.StrGenderName,

            ReligionId = data.IntReligionId,
            Religion = data.TblReligionInfo?.StrReligionName
        };
    }

    public static List<GetEmployeeBasicInfoLandingDto> GetEmployeeList(IList<TblEmployeeBasicInfo> data)
    {
        var map = data.Select(x => new GetEmployeeBasicInfoLandingDto
        {
            PrimaryId = x.IntPrimaryId,
            EmployeeName = x.StrEmployeeName,
            EmployeeCode = x.StrEmployeeCode,
            DateOfBirth = x.DteDateOfBirth,
            Department = (x.TblDepartmentInfo?.StrDepartmentName),
            Designation = x.TblDesignationInfo?.StrDesignationName,
            Gender = x.TblGenderInfo?.StrGenderName,
            Religion = x.TblReligionInfo?.StrReligionName
        }).ToList();

        return map;
    }
}