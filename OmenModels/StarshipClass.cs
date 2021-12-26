using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace OmenModels
{
    public class StarshipClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Slots { get; set; }

        public int BaseStealth { get; set; }

        public int BaseSpeed { get; set; }
    }
}
