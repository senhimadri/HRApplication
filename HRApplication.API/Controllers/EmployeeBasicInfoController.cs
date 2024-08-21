using HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.CreateEmployeebasicInfo;
using HRApplication.Application.Features.EmployeeManagement.GetEmployeesBasicInfoList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HRApplication.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeBasicInfoController : ControllerBase
{
    private readonly IMediator _mediator;
    public EmployeeBasicInfoController(IMediator mediator) => _mediator = mediator;


    [HttpPost]
    [Route("CreateNewEmployee")]
    public async Task<ActionResult> CreateNewEmployee ([FromBody] CreateEmployeeBasicInfoDto _employeeBasicInfo)
    {
        var command = new CreateEmployeeBasicInfoCommand { employeeBasicInfo = _employeeBasicInfo };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpPost]
    [Route("LandingEmployeesList")]
    public async Task<ActionResult> LandingEmployeesList (ParamsEmployeeBasicInfoLandingDto _LandingParameeter)
    {
        var request = new GetEmployeesBasicInfoListRequest { LandingParameeter= _LandingParameeter};
        var response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpGet]
    [Route("GetEmployeeDetails")]
    public async Task<ActionResult> GetEmployeeDetails (long _employeeId)
    {
        return Ok();
    }
}
