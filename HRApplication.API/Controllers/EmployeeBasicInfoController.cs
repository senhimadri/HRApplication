using HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.CreateEmployeebasicInfo;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeeBasicInfoDetailsById;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.GetEmployeesBasicInfoList;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.UpdateEmployeeBasicInfo;
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

    [HttpPut]
    [Route("UpdateEmployeeBasicInfo")]
    public async Task<ActionResult> UpdateEmployeeBasicInfo([FromBody] UpdateEmployeeBasicInfoDto _employeeBasicInfo)
    {
        var command = new UpdateEmployeeBasicInfoCommand { employeeBasicInfo = _employeeBasicInfo };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpPost]
    [Route("LandingEmployeesList")]
    public async Task<ActionResult> LandingEmployeesList (ParamsEmployeeBasicInfoLandingDto _landingParameeter)
    {
        var request = new GetEmployeesBasicInfoListRequest { LandingParameeter= _landingParameeter };
        var response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpGet]
    [Route("GetEmployeeDetails")]
    public async Task<ActionResult> GetEmployeeDetailsById(long _employeeId)
    {
        var request = new GetEmployeeBasicInfoDetailsByIdRequest { EmployeeId = _employeeId };
        var response = await _mediator.Send(request);
        return Ok(response);
    }
}
