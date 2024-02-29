﻿using HRApplication.Domain.EmployeeManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRApplication.Persistence.DomainConfiguration.EmployeeManagement;

public class TblGenderInfoConfiguration : IEntityTypeConfiguration<TblGenderInfo>
{
    public void Configure(EntityTypeBuilder<TblGenderInfo> builder)
    {
        builder.HasData(
            new TblGenderInfo
            {
                IntPrimaryId = 1,
                StrGenderName = "Male",
                StrGenderCode = "M"
            },
            new TblGenderInfo
            {
                IntPrimaryId = 2,
                StrGenderName = "Female",
                StrGenderCode = "F"
            },
            new TblGenderInfo
            {
                IntPrimaryId = 3,
                StrGenderName = "Others",
                StrGenderCode = "O"
            });
    }
}

