using HRApplication.Domain.MasterConfiguratioDomain;
using System.ComponentModel.DataAnnotations;

namespace HRApplication.Domain.CommonDomain;
public abstract class BaseDomainEntity
{
    public long IntPrimaryId { get; set; }
    public long IntCreatedBy { get; set; }
    public DateTime DteCtratedAt { get; set; }
    public long IntUpdatedBy { get; set; }
    public DateTime  DteUpdatedAt { get; set; }
    public bool IsActive { get; set; }
    public int IntAccountId { get; set; }
}


