using HRApplication.Domain.EmployeeManagement;
using HRApplication.Domain.LeaveApplication;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApplication.Persistence;

public class HRApplicationDBContext: DbContext
{

    public HRApplicationDBContext(DbContextOptions<HRApplicationDBContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HRApplicationDBContext).Assembly);
    }

    //-- Employee Management
    public DbSet<TblDepartmentInfo> TblDepartmentInfo { get; set; }
    public DbSet<TblDesignationInfo> TblDesignationInfo { get; set; }
    public DbSet<TblGenderInfo> TblGenderInfo { get; set; }
    public DbSet<TblReligionInfo> TblReligionInfo { get; set; }
    public DbSet<TblEmployeeBasicInfo> TblEmployeeBasicInfo { get; set; }

    //-- Leave Application
    public DbSet<TblLeaveTypeInfo> TblLeaveTypeInfo { get; set; }
    public DbSet<TblLeaveApplication> TblLeaveApplication { get; set; }
    public DbSet<TblLeaveBalance> TblLeaveBalance { get; set; }
}

