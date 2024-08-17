using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Domain.EmployeeManagement;
using System.Security.AccessControl;

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

    public static GetEmployeeBasicInfoDto GetEmployee(TblEmployeeBasicInfo data)
    {
        return new GetEmployeeBasicInfoDto()
        {
            IntPrimaryId = data.IntReligionId,
            StrEmployeeName = data.StrEmployeeName,
            StrEmployeeCode =data.StrEmployeeCode,
            DteDateOfBirth = data.DteDateOfBirth,
            StrDepartment = data.TblDepartmentInfo?.StrDepartmentName,
            StrDesignation = data.TblDesignationInfo?.StrDesignationName,
            StrGender = data.TblGenderInfo?.StrGenderName,
            StrReligionId = data.TblReligionInfo?.StrReligionName
        };
    }

    public static List<GetEmployeeBasicInfoDto> GetEmployeeList(IQueryable<TblEmployeeBasicInfo> data)
    {
        return data.Select(x=> new GetEmployeeBasicInfoDto
        {
            IntPrimaryId = x.IntReligionId,
            StrEmployeeName = x.StrEmployeeName,
            StrEmployeeCode =x.StrEmployeeCode,
            DteDateOfBirth = x.DteDateOfBirth,
            StrDepartment = (x.TblDepartmentInfo.StrDepartmentName),
            StrDesignation = x.TblDesignationInfo.StrDesignationName,
            StrGender = x.TblGenderInfo.StrGenderName,
            StrReligionId = x.TblReligionInfo.StrReligionName
        }).ToList();
    }
}