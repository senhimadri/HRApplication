using HRApplication.Domain.EmployeeManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRApplication.Persistence.DomainConfiguration.EmployeeManagement;

public class TblDesignationInfoConfiguration : IEntityTypeConfiguration<TblDesignationInfo>
{
    public void Configure(EntityTypeBuilder<TblDesignationInfo> builder)
    {
        builder.ToTable("TblDesignationInfo", "emp");

        builder.Property(e => e.StrDesignationName)
            .HasMaxLength(100);

        builder.Property(e => e.StrDesignationCode)
           .HasMaxLength(50);

        builder.HasData(
            new TblDesignationInfo
            {
                IntPrimaryId = 1,
                StrDesignationName = "Admin",
                StrDesignationCode = "ADM001"
            });


    }
}

