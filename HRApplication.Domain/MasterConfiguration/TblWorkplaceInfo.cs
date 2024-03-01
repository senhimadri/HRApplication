using HRApplication.Domain.CommonDomain;

namespace HRApplication.Domain.MasterConfiguratio;

public class TblWorkplaceInfo : BaseDomainEntity
{
    public string StrWorkplaceName { get; set; } = string.Empty;
    public string StrWorkplaceDescreption { get; set; } = string.Empty;

    //public long IntAccountId { get; set; }
    //public TblAccountInfo TblAccountInfo { get; set; } = new TblAccountInfo();

    //public long IntBusinessUnitId { get; set; }
    //public TblBusinessUnitInfo TblBusinessUnitInfo { get; set; } = new TblBusinessUnitInfo();

    public long IntWorkplaceGroupId { get; set; }
    public TblWorkplaceGroupInfo TblWorkplaceGroupInfo { get; set; } = new TblWorkplaceGroupInfo();
}

