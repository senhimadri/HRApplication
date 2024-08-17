using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.CreateEmployeebasicInfo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HRApplication.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeBasicInfoController : ControllerBase
{
    private readonly IMediator _mediator;
    public EmployeeBasicInfoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult> CreateNewEmployee ([FromBody] CreateEmployeeBasicInfoDto _employeeBasicInfo)
    {
        var command = new CreateEmployeeBasicInfoCommand { employeeBasicInfo = _employeeBasicInfo };
        var response = await _mediator.Send(command);
        return Ok(response);
    }
}
