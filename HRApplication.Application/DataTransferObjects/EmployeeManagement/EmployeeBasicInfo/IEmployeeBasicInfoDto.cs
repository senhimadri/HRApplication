﻿namespace HRApplication.Application.DataTransferObjects.EmployeeManagement.EmployeeBasicInfo;

public interface IEmployeeBasicInfoDto
{
    public string? EmployeeName { get; set; }
    public string? EmployeeCode { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public long DepartmentId { get; set; }
    public long DesignationId { get; set; }
    public long GenderId { get; set; }
    public long ReligionId { get; set; }
}