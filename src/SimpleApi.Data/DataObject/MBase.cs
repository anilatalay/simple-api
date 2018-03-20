using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SimpleApi.Data.DataObject
{
    [BsonIgnoreExtraElements]
    public class MBase
    {
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}