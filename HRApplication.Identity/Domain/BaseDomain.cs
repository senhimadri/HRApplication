namespace HRApplication.Identity.Domain;

public class BaseEntity
{
    public Guid Id { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid CreatedBy { get; set; }
}
