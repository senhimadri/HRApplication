using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Domain.EmployeeManagement;
using MediatR;
using System.Linq.Expressions;

namespace HRApplication.Application.Features.EmployeeManagement.GetEmployeesBasicInfoList;

public class GetEmployeesBasicInfoListRequestHandler : IRequestHandler<GetEmployeesBasicInfoListRequest, List<GetEmployeeBasicInfoDto>>
{
    private readonly IUnitofWork _unitofWork;

    public GetEmployeesBasicInfoListRequestHandler(IUnitofWork unitofWork) => _unitofWork=unitofWork;


    public async Task<List<GetEmployeeBasicInfoDto>> Handle(GetEmployeesBasicInfoListRequest request, CancellationToken cancellationToken)
    {

        var Filter = GetFilter(request);

        var EmployeeDetails = await _unitofWork.EmployeeBasicInfoRepository
                                    .GetEmployeeDetailsList(Filter);

        return EmployeeBasicInfoMap.GetEmployeeList(EmployeeDetails);
    }


    private Expression<Func<TblEmployeeBasicInfo, bool>> GetFilter(GetEmployeesBasicInfoListRequest request)
    {
        Func<TblEmployeeBasicInfo, bool> SearchTextFilter = x =>
                                        request.SearchText is not null ?
                                        ((x.StrEmployeeName??string.Empty).Contains(request.SearchText)
                                            || (x.StrEmployeeCode??string.Empty).Contains(request.SearchText)
                                            || (x.TblDepartmentInfo?.StrDepartmentName ?? string.Empty).Contains(request.SearchText)
                                            || (x.TblDesignationInfo?.StrDesignationName ?? string.Empty).Contains(request.SearchText)
                                            || (x.TblReligionInfo?.StrReligionName ?? string.Empty).Contains(request.SearchText)
                                            || (x.TblGenderInfo?.StrGenderName ?? string.Empty).Contains(request.SearchText))
                                        : true;

        Func<TblEmployeeBasicInfo, bool> SearchDepartment = x => request.DepartmentId   ==   0 || x.IntDepartmentId==request.DepartmentId;
        Func<TblEmployeeBasicInfo, bool> SearchDesignation = x => request.DesignationId  ==   0 || x.IntDesignationId==request.DesignationId;
        Func<TblEmployeeBasicInfo, bool> SearchGender = x => request.GenderId  == 0 || x.IntGenderId==request.GenderId;

        Expression<Func<TblEmployeeBasicInfo, bool>> filter = x => SearchTextFilter(x) &&
                                                                    SearchDepartment(x) &&
                                                                    SearchDesignation(x) &&

                                                                    SearchGender(x);

        return filter;

    }

}