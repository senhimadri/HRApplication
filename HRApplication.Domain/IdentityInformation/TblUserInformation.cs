using HRApplication.Domain.EmployeeManagement;

namespace HRApplication.Domain.IdentityInformation;

public class TblUserInformation
{
    public Guid Id { get; set; }
    public string? UserName { get; set; }
    public string? UserRole { get; set; }
    public DateTime CreatedAt { get; set; }
    public TblEmployeeBasicInfo? TblEmployeeBasicInfo { get; set; }
}
