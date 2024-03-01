namespace HRApplication.Domain.CommonDomain;

public abstract class MasterConfigEntiy: BaseDomainEntity
{
    public long IntAccountId { get; set; }
    public long IntBusinessUnitId { get; set; }
    public long IntWorkplaceGroupId { get; set; }
    public long IntWorkPlaceId { get; set; }
}


