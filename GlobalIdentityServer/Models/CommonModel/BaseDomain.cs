using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GlobalIdentityServer.Models.CommonModel;

public class BaseDomain
{
    public BaseDomain(BaseDomain _baseDomain)
    {
        Id = _baseDomain.Id;
        CreatedAt = _baseDomain.CreatedAt;
        CreatedBy = _baseDomain.CreatedBy;
        UpdatedAt = _baseDomain.UpdatedAt;
        UpdatedBy = _baseDomain.UpdatedBy;
        IsActive = _baseDomain.IsActive;
    }


    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; set; }


    [BsonRepresentation(BsonType.String)]
    public DateTime CreatedAt { get; set; }

    [BsonRepresentation(BsonType.String)]
    public Guid CreatedBy { get; set; }

    [BsonRepresentation(BsonType.String)]
    public DateTime? UpdatedAt { get; set; }

    [BsonRepresentation(BsonType.String)]
    public Guid? UpdatedBy { get; set; }

    [BsonRepresentation(BsonType.Boolean)]
    public bool IsActive { get; set; }
}
