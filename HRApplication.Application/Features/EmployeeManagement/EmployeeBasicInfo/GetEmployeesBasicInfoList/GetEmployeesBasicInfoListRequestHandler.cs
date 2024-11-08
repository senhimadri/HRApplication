using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.CommonDTO;
using HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.Helper;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Application.Results;
using HRApplication.Domain.EmployeeManagement;
using LinqKit;
using MediatR;
using System.Linq.Expressions;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeesBasicInfoList;

public class GetEmployeesBasicInfoListRequestHandler(IUnitofWork unitofWork) : IRequestHandler<GetEmployeesBasicInfoListRequest, Result<GetLandingPagination<GetEmployeeBasicInfoLandingDto>>>
{
    private readonly IUnitofWork _unitofWork = unitofWork;

    public async Task<Result<GetLandingPagination<GetEmployeeBasicInfoLandingDto>>> Handle(GetEmployeesBasicInfoListRequest request, CancellationToken cancellationToken)
    {
        if (request.LandingParameeter is null)
            return Errors.ContentNotFound;

        var employeeLandingFilter = BuildEmployeeLandingFilter(request);

        var employeeDetails = await FetchEmployeeDetails(employeeLandingFilter, request.LandingParameeter.PageNo, request.LandingParameeter.PageSize);

        if (employeeDetails.Data is null || !employeeDetails.Data.Any())
            return Errors.ContentNotFound;

        return employeeDetails;
    }


    private async Task<GetLandingPagination<GetEmployeeBasicInfoLandingDto>> FetchEmployeeDetails(Expression<Func<TblEmployeeBasicInfo, bool>> filter, int PageNo,int PageSize)
    {
        return await _unitofWork.EmployeeBasicInfoRepository
                                .GetEmployeeDetailsQuery(filter)
                                .MapToEmployeeLandingDto()
                                .ToPaginatedResultAsync(PageNo, PageSize);
    }

    private Expression<Func<TblEmployeeBasicInfo, bool>> BuildEmployeeLandingFilter(GetEmployeesBasicInfoListRequest request)
    {
        var filter = PredicateBuilder.New<TblEmployeeBasicInfo>(true);

        string? searchText = request.LandingParameeter?.SearchText;

        if (!string.IsNullOrEmpty(searchText))
            filter = filter.And(x =>
              (x.StrEmployeeName != null && x.StrEmployeeName.Contains(searchText)) ||
              (x.StrEmployeeCode != null && x.StrEmployeeCode.Contains(searchText)) ||
              (x.TblDepartmentInfo != null && x.TblDepartmentInfo.StrDepartmentName != null && x.TblDepartmentInfo.StrDepartmentName.Contains(searchText)) ||
              (x.TblDesignationInfo != null && x.TblDesignationInfo.StrDesignationName != null && x.TblDesignationInfo.StrDesignationName.Contains(searchText)) ||
              (x.TblReligionInfo != null && x.TblReligionInfo.StrReligionName != null && x.TblReligionInfo.StrReligionName.Contains(searchText)) ||
              (x.TblGenderInfo != null && x.TblGenderInfo.StrGenderName != null && x.TblGenderInfo.StrGenderName.Contains(searchText)));

        if (request.LandingParameeter?.DepartmentIdList?.Any() == true)
            filter = filter.And(x => request.LandingParameeter.DepartmentIdList.Contains(x.IntDepartmentId));

        if (request.LandingParameeter?.DesignationIdList?.Any() == true)
            filter = filter.And(x => request.LandingParameeter.DesignationIdList.Contains(x.IntDesignationId));

        if (request.LandingParameeter?.GenderIdList?.Any() == true)
            filter = filter.And(x => request.LandingParameeter.GenderIdList.Contains(x.IntGenderId));

        if (request.LandingParameeter?.ReligionIdList?.Any() == true )
            filter = filter.And(x => request.LandingParameeter.ReligionIdList.Contains(x.IntReligionId));

        return filter;
    }

}