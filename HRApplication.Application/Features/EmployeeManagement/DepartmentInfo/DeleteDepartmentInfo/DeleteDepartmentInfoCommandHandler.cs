using HRApplication.Application.Contracts.Parsistence;
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
            throw new ArgumentNullException("No Department is available");

        DepartmentInfo.IsActive = false;
        await _unitofWork.DepartmentInfoRepository.ModifyOne(DepartmentInfo);
        await _unitofWork.SaveAsync();

        return Unit.Value;
    }
}