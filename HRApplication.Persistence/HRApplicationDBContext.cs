﻿using HRApplication.Domain.CommonDomain;
using HRApplication.Domain.EmployeeManagement;
using HRApplication.Domain.LeaveApplication;
using HRApplication.Domain.MasterConfiguratio;
using Microsoft.EntityFrameworkCore;

namespace HRApplication.Persistence;

public class HRApplicationDBContext: DbContext
{

    public HRApplicationDBContext(DbContextOptions<HRApplicationDBContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HRApplicationDBContext).Assembly);

        var entityTypes = modelBuilder.Model.GetEntityTypes()
            .Where(e => typeof(BaseDomainEntity).IsAssignableFrom(e.ClrType));

        foreach (var entityType in entityTypes)
        {
            modelBuilder.Entity(entityType.ClrType)
                .HasKey("IntPrimaryId");
        }
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entity in ChangeTracker.Entries<BaseDomainEntity>())
        {
            entity.Entity.DteUpdatedAt = DateTime.UtcNow;

            if (entity.State == EntityState.Added)
            {
                entity.Entity.DteCtratedAt = DateTime.UtcNow;
                entity.Entity.IsActive = true;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
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

    // Master Configuration
    public DbSet<TblAccountInfo> TblAccountInfo { get; set; }
    public DbSet<TblBusinessUnitInfo> TblBusinessUnitInfo { get; set; }
    public DbSet<TblWorkplaceGroupInfo> TblWorkplaceGroupInfo { get; set; }
    public DbSet<TblWorkplaceInfo> TblWorkplaceInfo { get; set; }

}

