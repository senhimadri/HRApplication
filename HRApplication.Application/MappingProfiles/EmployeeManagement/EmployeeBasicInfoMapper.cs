using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Domain.EmployeeManagement;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HRApplication.Application.MappingProfiles.EmployeeManagement;

public static class EmployeeBasicInfoMapper
{
    public static TblEmployeeBasicInfo MapToEmployeeEntity(this CreateEmployeeBasicInfoDto data)
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

    public static void MapWithUpdateEmployeeDto(this TblEmployeeBasicInfo existing, UpdateEmployeeBasicInfoDto input)
    {
        existing.StrEmployeeName = input.EmployeeName;
        existing.StrEmployeeCode = input.EmployeeCode;
        existing.DteDateOfBirth = input.DateOfBirth;
        existing.IntDepartmentId = input.DepartmentId;
        existing.IntDesignationId = input.DesignationId;
        existing.IntGenderId = input.GenderId;
        existing.IntReligionId = input.ReligionId;
    }

    public static IQueryable<GetEmployeeBasicInfoDto> MapToEmployeeBasicInfoDto(this IQueryable<TblEmployeeBasicInfo> query)
    {
        return query.Select(x => new GetEmployeeBasicInfoDto
        {
            PrimaryId = x.IntPrimaryId,
            EmployeeName = x.StrEmployeeName,
            EmployeeCode = x.StrEmployeeCode,
            DateOfBirth = x.DteDateOfBirth,

            DepartmentId = x.IntDepartmentId,
            Department = x.TblDepartmentInfo != null ? x.TblDepartmentInfo.StrDepartmentName : null,

            DesignationId = x.IntDesignationId,
            Designation = x.TblDesignationInfo != null ? x.TblDesignationInfo.StrDesignationName : null,

            GenderId = x.IntGenderId,
            Gender = x.TblGenderInfo != null ? x.TblGenderInfo.StrGenderName : null,

            ReligionId = x.IntReligionId,
            Religion = x.TblReligionInfo != null ? x.TblReligionInfo.StrReligionName : null
        });
    }

    public static IQueryable<GetEmployeeBasicInfoLandingDto> MapToEmployeeLandingDto(this IQueryable<TblEmployeeBasicInfo> query)
    {
        return query.Select(x => new GetEmployeeBasicInfoLandingDto
        {
            PrimaryId = x.IntPrimaryId,
            EmployeeName = x.StrEmployeeName,
            EmployeeCode = x.StrEmployeeCode,
            DateOfBirth = x.DteDateOfBirth,
            Department = x.TblDepartmentInfo != null ? x.TblDepartmentInfo.StrDepartmentName : null,
            Designation = x.TblDesignationInfo != null ? x.TblDesignationInfo.StrDesignationName : null,
            Gender = x.TblGenderInfo != null ? x.TblGenderInfo.StrGenderName : null,
            Religion = x.TblReligionInfo != null ? x.TblReligionInfo.StrReligionName : null
        });
    }
}