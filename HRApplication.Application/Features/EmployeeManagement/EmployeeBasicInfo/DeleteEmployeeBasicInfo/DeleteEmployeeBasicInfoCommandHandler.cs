using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Exceptions;
using HRApplication.Domain.EmployeeManagement;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.DeleteEmployeeBasicInfo;

public class DeleteEmployeeBasicInfoCommandHandler : IRequestHandler<DeleteEmployeeBasicInfoCommand, Unit>
{
    private readonly IUnitofWork _unitofWork;
    public DeleteEmployeeBasicInfoCommandHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;


    public async Task<Unit> Handle(DeleteEmployeeBasicInfoCommand request, CancellationToken cancellationToken)
    {
        var EmployeeDetails = await _unitofWork.EmployeeBasicInfoRepository.GetOne(request.EmployeeId);

        if (EmployeeDetails is null)
            throw new NotFoundException(name: nameof(TblEmployeeBasicInfo), key: request.EmployeeId);

        EmployeeDetails.IsActive = false;

        await _unitofWork.EmployeeBasicInfoRepository.ModifyOne(EmployeeDetails);
        await _unitofWork.SaveAsync();

        return Unit.Value;
    }
}