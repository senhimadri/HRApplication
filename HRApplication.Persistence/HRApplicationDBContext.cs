﻿using HRApplication.Domain.CommonDomain;
using HRApplication.Domain.EmployeeManagement;
using HRApplication.Domain.LeaveManagement;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HRApplication.Persistence;

public class HRApplicationDBContext : DbContext
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

            modelBuilder.Entity(entityType.ClrType)
                .Property("IntPrimaryId")
                .ValueGeneratedOnAdd();

            // Apply global query filter for IsDeleted property
            if (entityType.ClrType.GetProperty("IsActive") != null)
            {
                var parameter = Expression.Parameter(entityType.ClrType, "e");
                var property = Expression.Property(parameter, "IsActive");
                var constant = Expression.Constant(true);
                var body = Expression.Equal(property, constant);
                var lambda = Expression.Lambda(body, parameter);

                modelBuilder.Entity(entityType.ClrType)
                    .HasQueryFilter(lambda);
            }
        }
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entity in ChangeTracker.Entries<BaseDomainEntity>())
        {
            entity.Entity.IntAccountId = 1;
            if (entity.State == EntityState.Added)
            {
                entity.Entity.DteCtrated = DateTime.UtcNow;
                entity.Entity.IntCreatedBy = 1;
                entity.Entity.IsActive = true;
            }
            else if (entity.State == EntityState.Modified)
            {
                entity.Entity.DteUpdatedAt = DateTime.UtcNow;
                entity.Entity.IntUpdatedBy = 1;
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

    public DbSet<AccountInformation> AccountInformation { get; set; }



}

