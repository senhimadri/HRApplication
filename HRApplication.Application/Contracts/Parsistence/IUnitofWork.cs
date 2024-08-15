﻿using HRApplication.Application.Contracts.Parsistence.EmployeeManagement;
namespace HRApplication.Application.Contracts.Parsistence;

public interface IUnitofWork
{
    IEmployeeBasicInfoRepository EmployeeBasicInfoRepository { get; }
    Task SaveAsync();
}