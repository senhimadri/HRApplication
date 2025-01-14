namespace HRApplication.Domain.CommonDomain;
public class BaseDomainEntity
{
    public long IntPrimaryId { get; set; }
    public long IntCreatedBy { get; set; }
    public DateTime DteCtrated { get; set; }
    public long IntUpdatedBy { get; set; }
    public DateTime? DteUpdatedAt { get; set; }
    public bool IsActive { get; set; }
    public long IntAccountId { get; set; }
}


