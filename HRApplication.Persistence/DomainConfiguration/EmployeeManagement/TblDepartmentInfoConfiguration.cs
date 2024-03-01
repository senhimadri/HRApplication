using HRApplication.Domain.EmployeeManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRApplication.Persistence.DomainConfiguration.EmployeeManagement;

public class TblDepartmentInfoConfiguration : IEntityTypeConfiguration<TblDepartmentInfo>
{
    public void Configure(EntityTypeBuilder<TblDepartmentInfo> builder)
    {
        builder.ToTable("TblDepartmentInfo", "emp");

        builder.Property(e => e.StrDepartmentName)
            .HasMaxLength(100);

        builder.Property(e => e.StrDepartmentCode)
           .HasMaxLength(50);

        builder.HasData(
            new TblDepartmentInfo
            {
                IntPrimaryId=1,
                StrDepartmentName="Administration",
                StrDepartmentCode="ADM001"
            });


    }
}

