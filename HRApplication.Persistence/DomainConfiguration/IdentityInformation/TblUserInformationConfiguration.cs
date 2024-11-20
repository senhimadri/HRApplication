using HRApplication.Domain.IdentityInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRApplication.Persistence.DomainConfiguration.IdentityInformation;

public class TblUserInformationConfiguration : IEntityTypeConfiguration<TblUserInformation>
{
    public void Configure(EntityTypeBuilder<TblUserInformation> builder)
    {
        builder.ToTable("TblUserInformation", "auth");

    }
}
