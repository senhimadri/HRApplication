using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GlobalIdentityServer.Models;

public class UserInformation
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; set; }
    public string? Username { get; set; }
    public string? PasswordHash { get; set; }
    public string? Email { get; set; }
    public bool IsVerified { get; set; }

    [BsonRepresentation(BsonType.String)]
    public DateTime CreatedAt { get; set; }

    [BsonRepresentation(BsonType.String)]
    public DateTime UpdatedAt { get; set; }
}
