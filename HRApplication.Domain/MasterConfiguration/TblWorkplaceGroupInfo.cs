using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.MasterConfiguratio;

public class TblWorkplaceGroupInfo : BaseDomainEntity
{
    public string StrWorkplaceGroupName { get; set; } = string.Empty;
    public string StrWorkplaceGroupDescreption { get; set; } = string.Empty;

    //public long IntAccountId { get; set; }
    //public TblAccountInfo TblAccountInfo { get; set; } = new TblAccountInfo();

    public long IntBusinessUnitId { get; set; }
    public TblBusinessUnitInfo TblBusinessUnitInfo { get; set; } = new TblBusinessUnitInfo();

    public ICollection<TblWorkplaceInfo> TblWorkplaceInfo { get; set; } = new Collection<TblWorkplaceInfo>();
}

