using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Exceptions;
using HRApplication.Domain.EmployeeManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.DeleteDepartmentInfo;

public class DeleteDepartmentInfoCommandHandler : IRequestHandler<DeleteDepartmentInfoCommand, Unit>
{
    private readonly IUnitofWork _unitofWork;
    public DeleteDepartmentInfoCommandHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;

    public async Task<Unit> Handle(DeleteDepartmentInfoCommand request, CancellationToken cancellationToken)
    {
        var DepartmentInfo =await _unitofWork.DepartmentInfoRepository.GetOne(request.PrimaryId);

        if (DepartmentInfo is null)
            throw new NotFoundException(name: nameof(TblDepartmentInfo), key: request.PrimaryId);

        DepartmentInfo.IsActive = false;

        await _unitofWork.DepartmentInfoRepository.ModifyOne(DepartmentInfo);
        await _unitofWork.SaveAsync();

        return Unit.Value;
    }
}