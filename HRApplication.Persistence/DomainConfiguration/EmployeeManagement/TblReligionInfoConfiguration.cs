using HRApplication.Domain.EmployeeManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRApplication.Persistence.DomainConfiguration.EmployeeManagement;

public class TblReligionInfoConfiguration : IEntityTypeConfiguration<TblReligionInfo>
{
    public void Configure(EntityTypeBuilder<TblReligionInfo> builder)
    {

        builder.ToTable("TblReligionInfo", "emp");

        builder.Property(e => e.StrReligionName)
            .HasMaxLength(20);

        builder.Property(e => e.StrReligionCode)
           .HasMaxLength(1);

        builder.HasData(
            new TblReligionInfo
            {
                IntPrimaryId = 1,
                StrReligionName = "Others",
                StrReligionCode = "O"
            });
    }
}

