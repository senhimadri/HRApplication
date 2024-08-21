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
            StrEmployeeName =data.EmployeeName,
            StrEmployeeCode =data.EmployeeCode,
            DteDateOfBirth =data.DateOfBirth,
            IntDepartmentId =data.DepartmentId,
            IntDesignationId =data.DesignationId,
            IntGenderId =data.GenderId,
            IntReligionId =data.ReligionId
        };
    }

    public static GetEmployeeBasicInfoDto GetEmployee(TblEmployeeBasicInfo data)
    {
        return new GetEmployeeBasicInfoDto()
        {
            PrimaryId = data.IntReligionId,
            EmployeeName = data.StrEmployeeName,
            EmployeeCode =data.StrEmployeeCode,
            DateOfBirth = data.DteDateOfBirth,
            Department = data.TblDepartmentInfo?.StrDepartmentName,
            Designation = data.TblDesignationInfo?.StrDesignationName,
            Gender = data.TblGenderInfo?.StrGenderName,
            Religion = data.TblReligionInfo?.StrReligionName
        };
    }

    public static List<GetEmployeeBasicInfoDto> GetEmployeeList(IList<TblEmployeeBasicInfo> data)
    {
        return data.Select(x=> new GetEmployeeBasicInfoDto
        {
            PrimaryId = x.IntReligionId,
            EmployeeName = x.StrEmployeeName,
            EmployeeCode =x.StrEmployeeCode,
            DateOfBirth = x.DteDateOfBirth,
            Department = (x.TblDepartmentInfo?.StrDepartmentName),
            Designation = x.TblDesignationInfo?.StrDesignationName,
            Gender = x.TblGenderInfo?.StrGenderName,
            Religion = x.TblReligionInfo?.StrReligionName
        }).ToList();
    }
}