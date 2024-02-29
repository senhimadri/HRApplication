using System.ComponentModel.DataAnnotations;

namespace HRApplication.Domain.CommonDomain;
public abstract class BaseDomainEntity
{
    [Key]
    public long IntPrimaryId { get; set; }
    public long IntCreatedBy { get; set; }
    public DateTime DteCtratedAt { get; set; }
    public long IntUpdatedBy { get; set; }
    public DateTime  DteUpdatedAt { get; set; }
    public bool IsActive { get; set; }
}


