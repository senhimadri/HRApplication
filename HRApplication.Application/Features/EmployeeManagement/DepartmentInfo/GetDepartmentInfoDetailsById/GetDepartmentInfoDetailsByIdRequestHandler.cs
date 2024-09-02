using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;
using HRApplication.Application.Exceptions;
using HRApplication.Application.MappingProfiles.EmployeeManagement;
using HRApplication.Domain.EmployeeManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.GetDepartmentInfoDetailsById;

public class GetDepartmentInfoDetailsByIdRequestHandler : IRequestHandler<GetDepartmentInfoDetailsByIdRequest, DepartmentInfoDto>
{
    private readonly IUnitofWork _unitofWork;
    public GetDepartmentInfoDetailsByIdRequestHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;

    public async Task<DepartmentInfoDto> Handle(GetDepartmentInfoDetailsByIdRequest request, CancellationToken cancellationToken)
    {
        var DepartmentDetails = await _unitofWork.DepartmentInfoRepository.GetOne(request.DepartmentId);

        if (DepartmentDetails is null)
            throw new NotFoundException(name: nameof(TblDepartmentInfo), key: request.DepartmentId);

        var result = DepartmentInfoMap.DepartmentInfo(DepartmentDetails);

        return result;
    }
}
