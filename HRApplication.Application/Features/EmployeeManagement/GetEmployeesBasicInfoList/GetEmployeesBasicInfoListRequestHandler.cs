using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.GetEmployeesBasicInfoList;

public class GetEmployeesBasicInfoListRequestHandler : IRequestHandler<GetEmployeesBasicInfoListRequest, List<GetEmployeeBasicInfoDto>>
{
    private readonly IUnitofWork _unitofWork;

    public GetEmployeesBasicInfoListRequestHandler(IUnitofWork unitofWork) => _unitofWork=unitofWork;


    public async Task<List<GetEmployeeBasicInfoDto>> Handle(GetEmployeesBasicInfoListRequest request, CancellationToken cancellationToken)
    {
        var EmployeeDetails = await _unitofWork.EmployeeBasicInfoRepository
                                    .GetMany(x => request.DepartmentId == 0 || x.IntDepartmentId ==request.DepartmentId);

        return  EmployeeBasicInfoMap.GetEmployee()
    }
}