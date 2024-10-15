using HRApplication.Application.DataTransferObjects.EmployeeManagement.DepartmentInfo;
using HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.CreateDepartmentInfo;
using HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.DeleteDepartmentInfo;
using HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.GetDepartmentInfoDetailsById;
using HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.GetDepartmentInfoList;
using HRApplication.Application.Features.EmployeeManagement.DepartmentInfo.UpdateDepartmentInfo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HRApplication.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentInfoController : ControllerBase
{
    private readonly IMediator _mediator;

    public DepartmentInfoController(IMediator mediator) => _mediator = mediator;


    [HttpPost]
    [Route("CreateNewDepartment")]
    public async Task<IActionResult> CreateNewDepartment([FromBody] CreateDepartmentDto _departmentinfo)
    {
        var command = new CreateDepartmentInfoCommand { Department = _departmentinfo };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpPut]
    [Route("UpdateDepartment")]
    public async Task<IActionResult> UpdateDepartment([FromBody] UpdateDepartmentDto _departmentinfo)
    {
        var command = new UpdateDepartmentInfoCommand { DepartmentInfo = _departmentinfo };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpDelete]
    [Route("DeleteDepartment")]
    public async Task<IActionResult> DeleteDepartment(long _primaryId)
    {
        var command = new DeleteDepartmentInfoCommand { PrimaryId = _primaryId };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpGet]
    [Route("LandingDepartmentList")]
    public async Task<IActionResult> LandingDepartmentList (string? _searchtext)
    {
        var request = new GetDepartmentInfoListRequest { SearchText = _searchtext };
        var response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpGet]
    [Route("GetDepartmentDetailsById")]
    public async Task<IActionResult> GetDepartmentDetailsById(long _departmentId)
    {
        var request = new GetDepartmentInfoDetailsByIdRequest { DepartmentId = _departmentId };
        var response = await _mediator.Send(request);
        return Ok(response); 
    }
}
