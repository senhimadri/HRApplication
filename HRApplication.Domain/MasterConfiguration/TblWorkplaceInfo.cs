using HRApplication.Domain.CommonDomain;

namespace HRApplication.Domain.MasterConfiguratio;

public class TblWorkplaceInfo : BaseDomainEntity
{
    public string? StrWorkplaceName { get; set; } 
    public string? StrWorkplaceDescreption { get; set; }
    public long IntWorkplaceGroupId { get; set; }
    public TblWorkplaceGroupInfo? TblWorkplaceGroupInfo { get; set; }
}

