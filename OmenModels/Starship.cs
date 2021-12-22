using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace OmenModels
{
    public class Starship
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Name { get; set; }

        public StarshipHull Hull { get; set; }

        public StarshipClass StarshipClass { get; set; }

        public List<ShipModule> Modules { get; set; }
    }
}
