using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GlobalIdentityServer.Models;

public class TblUser : BaseDomain
{
    public string? Username { get; set; }
    public string? PasswordHash { get; set; }
    public UserRole UserRole { get; set; }
}

public enum UserRole
{
    SuperAdmin, TenantAdmin, User
}
