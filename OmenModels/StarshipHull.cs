using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OmenModels
{
    public class StarshipHull
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Hitpoints { get; set; }

        public int Value { get; set; }

        public string SpecialAbility { get; set; }
    }
}
