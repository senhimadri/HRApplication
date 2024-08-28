using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeesBasicInfoList;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Domain.EmployeeManagement;
using LinqKit;
using MediatR;
using System.Linq.Expressions;

namespace HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.GetDepartmentInfoList;

public class GetDepartmentInfoListRequest : IRequest<List<DepartmentInfoDto>>
{
    public string? SearchText { get; set; }
}


public class GetDepartmentInfoListRequestHandler : IRequestHandler<GetDepartmentInfoListRequest, List<DepartmentInfoDto>>
{
    private readonly IUnitofWork _unitofWork;

    public GetDepartmentInfoListRequestHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;

    public async Task<List<DepartmentInfoDto>> Handle(GetDepartmentInfoListRequest request, CancellationToken cancellationToken)
    {

        var Filter = GetFilter(request);
        var DepartmentList =await _unitofWork.DepartmentInfoRepository.GetMany(Filter);

        return DepartmentInfoMap.DepartmentInfoList(DepartmentList);
    }

    private Expression<Func<TblDepartmentInfo, bool>> GetFilter(GetDepartmentInfoListRequest request)
    {
        var filter = PredicateBuilder.New<TblDepartmentInfo>(true);

        if (!string.IsNullOrEmpty(request.SearchText))
            filter = filter.And(x => (x.StrDepartmentName != null && x.StrDepartmentName.Contains(request.SearchText)) 
                            || (x.StrDepartmentCode != null && x.StrDepartmentCode.Contains(request.SearchText)));

        return filter;
    }
}
