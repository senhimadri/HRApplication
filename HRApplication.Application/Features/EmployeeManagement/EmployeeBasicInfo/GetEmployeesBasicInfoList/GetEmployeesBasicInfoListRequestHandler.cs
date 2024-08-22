using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Domain.EmployeeManagement;
using MediatR;
using System.Linq.Expressions;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeesBasicInfoList;

public class GetEmployeesBasicInfoListRequestHandler : IRequestHandler<GetEmployeesBasicInfoListRequest, List<GetEmployeeBasicInfoDto>>
{
    private readonly IUnitofWork _unitofWork;

    public GetEmployeesBasicInfoListRequestHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;


    public async Task<List<GetEmployeeBasicInfoDto>> Handle(GetEmployeesBasicInfoListRequest request, CancellationToken cancellationToken)
    {

        var Filter = GetFilter(request);

        var EmployeeDetails = await _unitofWork.EmployeeBasicInfoRepository
                                    .GetEmployeeDetailsList(Filter);

        return EmployeeBasicInfoMap.GetEmployeeList(EmployeeDetails);
    }


    private Expression<Func<TblEmployeeBasicInfo, bool>> GetFilter(GetEmployeesBasicInfoListRequest request)
    {
        Func<TblEmployeeBasicInfo, bool> SearchTextFilter = x => !String.IsNullOrEmpty(request.LandingParameeter?.SearchText) ?
                                                                (x.StrEmployeeName ?? string.Empty).Contains(request.LandingParameeter.SearchText)
                                                                    || (x.StrEmployeeCode ?? string.Empty).Contains(request.LandingParameeter.SearchText)
                                                                    || (x.TblDepartmentInfo?.StrDepartmentName ?? string.Empty).Contains(request.LandingParameeter.SearchText)
                                                                    || (x.TblDesignationInfo?.StrDesignationName ?? string.Empty).Contains(request.LandingParameeter.SearchText)
                                                                    || (x.TblReligionInfo?.StrReligionName ?? string.Empty).Contains(request.LandingParameeter.SearchText)
                                                                    || (x.TblGenderInfo?.StrGenderName ?? string.Empty).Contains(request.LandingParameeter.SearchText)
                                                                : true;

        Func<TblEmployeeBasicInfo, bool> SearchDepartment = x => request.LandingParameeter?.DepartmentIdList is not null 
                                                                        && request.LandingParameeter.DepartmentIdList.Any()
                                                                    ? request.LandingParameeter.DepartmentIdList.Contains(x.IntDepartmentId)
                                                                : true;

        Func<TblEmployeeBasicInfo, bool> SearchDesignation = x => request.LandingParameeter?.DesignationIdList is not null
                                                                        && request.LandingParameeter.DesignationIdList.Any()
                                                                    ? request.LandingParameeter.DesignationIdList.Contains(x.IntDesignationId)
                                                                : true;

        Func<TblEmployeeBasicInfo, bool> SearchGender = x => request.LandingParameeter?.GenderIdList is not null
                                                                        && request.LandingParameeter.GenderIdList.Any() 
                                                                    ? request.LandingParameeter.GenderIdList.Contains(x.IntGenderId)
                                                                : true;

        Func<TblEmployeeBasicInfo, bool> SearchReligion = x => request.LandingParameeter?.ReligionIdList is not null
                                                                        && request.LandingParameeter.ReligionIdList.Any()
                                                                    ? request.LandingParameeter.ReligionIdList.Contains(x.IntReligionId)
                                                                : true;

        Expression<Func<TblEmployeeBasicInfo, bool>> filter = x => SearchTextFilter(x) && SearchDepartment(x) &&
                                                                    SearchDesignation(x) && SearchGender(x) && SearchReligion(x);

        return filter;
    }

}