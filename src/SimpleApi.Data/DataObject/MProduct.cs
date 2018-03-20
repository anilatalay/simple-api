using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SimpleApi.Data.DataObject
{
    [BsonIgnoreExtraElements]
    public class MProduct: MBase
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("ProductId")]
        public string ProductId { get; set; }
        [BsonElement("Title")]
        public string Title { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        [BsonElement("CreatedDate")]
        public DateTime CreatedDate { get; set; }
    }
}