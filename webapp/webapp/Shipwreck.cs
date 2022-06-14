using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace webapp
{
    [BsonIgnoreExtraElements]
    public class Shipwreck
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("feature_type")]
        public string FeatureType { get; set; }
        [BsonElement("chart")]
        public string Chart { get; set; }
        [BsonElement("latdec")]
        public double Latitude { get; set; }
        [BsonElement("londec")]
        public double Longitude { get; set; }

    }
}
