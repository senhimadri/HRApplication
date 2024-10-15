using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.Helper;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Domain.EmployeeManagement;
using LinqKit;
using MediatR;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq.Expressions;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeesBasicInfoList;

public class GetEmployeesBasicInfoListRequestHandler : IRequestHandler<GetEmployeesBasicInfoListRequest, List<GetEmployeeBasicInfoLandingDto>>
{
    private readonly IUnitofWork _unitofWork;

    public GetEmployeesBasicInfoListRequestHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;


    public async Task<List<GetEmployeeBasicInfoLandingDto>> Handle(GetEmployeesBasicInfoListRequest request, CancellationToken cancellationToken)
    {
        if (request.LandingParameeter is null)
            throw new Exception();

        var Filter = GetFilter(request);

        var EmployeeDetails = await _unitofWork.EmployeeBasicInfoRepository
                                    .GetEmployeeDetailsQuery(Filter)
                                    .Pagination(request.LandingParameeter.PageNo, request.LandingParameeter.PageSize)
                                    .ToListAsync();
        if (EmployeeDetails is null)
            throw new Exception();

        return EmployeeBasicInfoMap.GetEmployeeList(EmployeeDetails);
    }


    private Expression<Func<TblEmployeeBasicInfo, bool>> GetFilter(GetEmployeesBasicInfoListRequest request)
    {
        var filter = PredicateBuilder.New<TblEmployeeBasicInfo>(true);

        if (!string.IsNullOrEmpty(request.LandingParameeter?.SearchText))
            filter = filter.And(x =>
              (x.StrEmployeeName != null && x.StrEmployeeName.Contains(request.LandingParameeter.SearchText)) ||
              (x.StrEmployeeCode != null && x.StrEmployeeCode.Contains(request.LandingParameeter.SearchText)) ||
              (x.TblDepartmentInfo != null && x.TblDepartmentInfo.StrDepartmentName != null && x.TblDepartmentInfo.StrDepartmentName.Contains(request.LandingParameeter.SearchText)) ||
              (x.TblDesignationInfo != null && x.TblDesignationInfo.StrDesignationName != null && x.TblDesignationInfo.StrDesignationName.Contains(request.LandingParameeter.SearchText)) ||
              (x.TblReligionInfo != null && x.TblReligionInfo.StrReligionName != null && x.TblReligionInfo.StrReligionName.Contains(request.LandingParameeter.SearchText)) ||
              (x.TblGenderInfo != null && x.TblGenderInfo.StrGenderName != null && x.TblGenderInfo.StrGenderName.Contains(request.LandingParameeter.SearchText)));


        if (request.LandingParameeter?.DepartmentIdList is not null && request.LandingParameeter.DepartmentIdList.Any())
            filter = filter.And(x => request.LandingParameeter.DepartmentIdList.Contains(x.IntDepartmentId));


        if (request.LandingParameeter?.DesignationIdList is not null && request.LandingParameeter.DesignationIdList.Any())
            filter = filter.And(x => request.LandingParameeter.DesignationIdList.Contains(x.IntDesignationId));

        if (request.LandingParameeter?.GenderIdList is not null && request.LandingParameeter.GenderIdList.Any())
            filter = filter.And(x => request.LandingParameeter.GenderIdList.Contains(x.IntGenderId));

        if (request.LandingParameeter?.ReligionIdList is not null && request.LandingParameeter.ReligionIdList.Any())
            filter = filter.And(x => request.LandingParameeter.ReligionIdList.Contains(x.IntReligionId));

        return filter;
    }

}