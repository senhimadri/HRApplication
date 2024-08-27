using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo.Validator;
using MediatR;

namespace HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.UpdateDepartmentInfo;

public class UpdateDepartmentInfoCommand : IRequest<Unit>
{
    public UpdateDepartmentInfo DepartmentInfo { get; set; }
}

public class UpdateDepartmentInfoCommandHandler : IRequestHandler<UpdateDepartmentInfoCommand, Unit>
{

    private readonly IUnitofWork _unitofWork;
    public UpdateDepartmentInfoCommandHandler(IUnitofWork unitofWork) => _unitofWork = unitofWork;

    public async Task<Unit> Handle(UpdateDepartmentInfoCommand request, CancellationToken cancellationToken)
    {
        var Validator = new UpdateDepartmentValidator(_unitofWork);

        var ValidationResult = await Validator.ValidateAsync(request.DepartmentInfo);


        return Unit.Value;
    }
}