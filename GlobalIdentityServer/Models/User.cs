using GlobalIdentityServer.Models.CommonModel;
using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GlobalIdentityServer.Models;

public class UserInformation : BaseDomain
{

    public UserInformation(UserInformation _information) : base(_information)
    {
        Username = _information.Username;
        PasswordHash = _information.PasswordHash;
        UserRole = _information.UserRole;
    }
    public string? Username { get; set; }
    public string? PasswordHash { get; set; }

    public UserRole UserRole { get; set; }


}

public enum UserRole
{
    SuperAdmin, TenantAdmin, User
}
