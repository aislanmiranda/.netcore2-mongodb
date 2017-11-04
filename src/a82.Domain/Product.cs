using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace a82.Domain
{
    public class MongoEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
    }

    public class Product : MongoEntity
    {
        [BsonElement("Qtd")]
        public int Qtd { get; set; }

        [BsonElement("Registry")]
        public DateTime Registry { get; set; }

    }
}
