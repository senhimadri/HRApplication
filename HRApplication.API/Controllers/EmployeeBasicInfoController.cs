using HRApplication.API.Helper;
using HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo;
using HRApplication.Application.DataTransferObjects.LeaveManagement;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.CreateEmployeebasicInfo;
using HRApplication.Application.Features.EmployeeManagement.EmployeeBasicInfo.DeleteEmployeeBasicInfo;
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
    public async Task<IActionResult> CreateNewEmployee([FromBody] CreateEmployeeBasicInfoDto _employeeBasicInfo)
    {
        var command = new CreateEmployeeBasicInfoCommand { employeeBasicInfo = _employeeBasicInfo };
        var response = await _mediator.Send(command);

        return response.Match(
            onSuccess: () => Ok(),
            onValidationFailure: validationErrors => ValidationProblem(validationErrors),
            onFailure: error => BadRequest(error)
        );
    }

    [HttpPut]
    [Route("UpdateEmployeeBasicInfo")]
    public async Task<IActionResult> UpdateEmployeeBasicInfo([FromBody] UpdateEmployeeBasicInfoDto _employeeBasicInfo)
    {
        var command = new UpdateEmployeeBasicInfoCommand { employeeBasicInfo = _employeeBasicInfo };
        var response = await _mediator.Send(command);

        return response.Match(
            onSuccess: () => Ok(),
            onValidationFailure: validationErrors => ValidationProblem(validationErrors),
            onFailure: error => BadRequest(error)
        );
    }

    [HttpDelete]
    [Route("DeleteEmployeeBasicInfo")]
    public async Task<IActionResult> DeleteEmployeeBasicInfo(long _employeeId)
    {
        var command = new DeleteEmployeeBasicInfoCommand { EmployeeId = _employeeId };
        var response = await _mediator.Send(command);

        return response.Match(
             onSuccess: () => Ok(),
             onValidationFailure: validationErrors => BadRequest(validationErrors),
             onFailure: error => BadRequest(error.Description)
         );
    }

    [HttpPost]
    [Route("LandingEmployeesList")]
    public async Task<IActionResult> LandingEmployeesList(ParamsEmployeeBasicInfoLandingDto _landingParameeter)
    {
        var request = new GetEmployeesBasicInfoListRequest { LandingParameeter = _landingParameeter };
        var response = await _mediator.Send(request);

        return response.Match(
                     onSuccess: data => Ok(data),
                     onFailure: error => BadRequest(error)
                 );
    }

    [HttpGet]
    [Route("GetEmployeeDetailsById")]
    public async Task<IActionResult> GetEmployeeDetailsById(long _employeeId)
    {
        var request = new GetEmployeeBasicInfoDetailsByIdRequest { EmployeeId = _employeeId };
        var response = await _mediator.Send(request);

        return response.Match(
                     onSuccess: data => Ok(data),
                     onFailure: error => BadRequest(error)
                 );
    }
}
