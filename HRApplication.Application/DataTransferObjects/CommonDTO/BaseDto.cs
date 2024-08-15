namespace HRApplication.Application.DataTransferObjects.CommonDTO;

public class BaseDto
{
    public long IntPrimaryId { get; set; }
    public long IntCreatedBy { get; set; }
    public DateTime DteCtratedAt { get; set; }
    public long IntUpdatedBy { get; set; }
    public DateTime DteUpdatedAt { get; set; }
    public bool IsActive { get; set; }
}