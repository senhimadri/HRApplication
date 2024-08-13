using HRApplication.Domain.MasterConfiguratio;

namespace HRApplication.Domain.CommonDomain;

public class MasterConfigEntiy: BaseDomainEntity
{
    public long IntAccountId { get; set; }

    public TblAccountInfo? TblAccountInfo { get; set; }
    public long IntBusinessUnitId { get; set; }
    public TblBusinessUnitInfo? TblBusinessUnitInfo { get; set; }
    public long IntWorkplaceGroupId { get; set; }
    public TblWorkplaceGroupInfo? TblWorkplaceGroupInfo { get; set; }
    public long IntWorkPlaceId { get; set; }
    public TblWorkplaceInfo? TblWorkplaceInfo { get; set; }
}


