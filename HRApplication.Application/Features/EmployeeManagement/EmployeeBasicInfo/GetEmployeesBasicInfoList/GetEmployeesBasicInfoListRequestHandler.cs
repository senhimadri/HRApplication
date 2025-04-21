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

        IEmployeeFilterBuilder empFilter = new EmployeeFilterBuilder();

        var employeeLandingFilter = empFilter
                                    .IncludeSearchText(request.LandingParameeter?.SearchText)
                                    .IncludeDepartmentIdList(request.LandingParameeter?.DepartmentIdList)
                                    .Build();

        var employeeDetails = await FetchEmployeeDetails(employeeLandingFilter, request.LandingParameeter?.PageNo ?? 1, request.LandingParameeter?.PageSize ??0);

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

public interface IEmployeeFilterBuilder
{
    IEmployeeFilterBuilder IncludeSearchText(string? searchText);
    IEmployeeFilterBuilder IncludeDepartmentIdList(List<long>? departmentIdList);
    IEmployeeFilterBuilder IncludeDepartmentId(long departmentId);
    IEmployeeFilterBuilder IncludeDesignationIdList(List<long>? designationIdList);
    IEmployeeFilterBuilder IncludeDesignationId(long designationId);
    IEmployeeFilterBuilder IncludeGenderIdList(List<long>? genderIdList);
    IEmployeeFilterBuilder IncludeGenderId(long genderId);
    IEmployeeFilterBuilder IncludeReligionIdList(List<long>? religionIdList);
    IEmployeeFilterBuilder IncludeReligionId(long religionId);

    Expression<Func<TblEmployeeBasicInfo, bool>> Build();

}

public class EmployeeFilterBuilder : IEmployeeFilterBuilder
{
    private ExpressionStarter<TblEmployeeBasicInfo> filter;

    public EmployeeFilterBuilder()=>  filter = PredicateBuilder.New<TblEmployeeBasicInfo>(true);

    public IEmployeeFilterBuilder IncludeSearchText(string? searchText)
    {
        if (!string.IsNullOrEmpty(searchText))
            filter = filter.And(x =>
               (x.StrEmployeeName != null && x.StrEmployeeName.Contains(searchText)) ||
               (x.StrEmployeeCode != null && x.StrEmployeeCode.Contains(searchText)) ||
               (x.TblDepartmentInfo != null && x.TblDepartmentInfo.StrDepartmentName != null && x.TblDepartmentInfo.StrDepartmentName.Contains(searchText)) ||
               (x.TblDesignationInfo != null && x.TblDesignationInfo.StrDesignationName != null && x.TblDesignationInfo.StrDesignationName.Contains(searchText)) ||
               (x.TblReligionInfo != null && x.TblReligionInfo.StrReligionName != null && x.TblReligionInfo.StrReligionName.Contains(searchText)) ||
               (x.TblGenderInfo != null && x.TblGenderInfo.StrGenderName != null && x.TblGenderInfo.StrGenderName.Contains(searchText)));
        return this;
    }
   
    public IEmployeeFilterBuilder IncludeDepartmentId(long departmentId)
    {
        filter = filter.And(x => departmentId == 0 || x.IntDepartmentId == departmentId);
        return this;
    }

    public IEmployeeFilterBuilder IncludeDepartmentIdList(List<long>? departmentIdList)
    {
        if (departmentIdList?.Any()==true)
            filter = filter.And(x => departmentIdList.Contains(x.IntDepartmentId));
        return this;
    }

    public IEmployeeFilterBuilder IncludeDesignationId(long designationId)
    {
        filter = filter.And(x => designationId == 0 || x.IntDesignationId == designationId);
        return this;
    }

    public IEmployeeFilterBuilder IncludeDesignationIdList(List<long>? designationIdList)
    {
        if (designationIdList?.Any() == true)
            filter = filter.And(x => designationIdList.Contains(x.IntDesignationId));
        return this;
    }

    public IEmployeeFilterBuilder IncludeGenderId(long genderId)
    {
        filter = filter.And(x => genderId == 0 || x.IntGenderId == genderId);
        return this;
    }

    public IEmployeeFilterBuilder IncludeGenderIdList(List<long>? genderIdList)
    {
        if (genderIdList?.Any() == true)
            filter = filter.And(x => genderIdList.Contains(x.IntGenderId));

        return this;
    }

    public IEmployeeFilterBuilder IncludeReligionId(long religionId)
    {
        filter = filter.And(x => religionId == 0 || x.IntReligionId == religionId);

        return this;
    }

    public IEmployeeFilterBuilder IncludeReligionIdList(List<long>? religionIdList)
    {
        if (religionIdList?.Any() == true)
            filter = filter.And(x => religionIdList.Contains(x.IntReligionId));

        return this;
    }

    public Expression<Func<TblEmployeeBasicInfo, bool>> Build() => filter;
}