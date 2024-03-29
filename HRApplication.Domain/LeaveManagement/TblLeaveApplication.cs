﻿using HRApplication.Domain.CommonDomain;
using HRApplication.Domain.EmployeeManagement;


namespace HRApplication.Domain.LeaveManagement;

public class TblLeaveApplication : MasterConfigEntiy
{
    public long IntEmployeeId { get; set; }
    public TblEmployeeBasicInfo TblEmployeeBasicInfo { get; set; } = new TblEmployeeBasicInfo();

    public long IntLeaveTypeId { get; set; }
    public TblLeaveTypeInfo TblLeaveTypeInfo { get; set; } = new TblLeaveTypeInfo();

    public DateOnly DteApplicationDate { get; set; }
    public DateOnly DteFromDate { get; set; }
    public DateOnly DteToDate { get; set; }
    public string StrLeaveReason { get; set; } = string.Empty;
}

