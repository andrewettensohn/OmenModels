using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Text.Json.Serialization;

namespace OmenModels
{
    public class ShipModule
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int SlotSpacesRequired { get; set; }

        public int PowerRequirement { get; set; }

        public DamageType DamageType { get; set; }

        public int Damage { get; set; }

        public int Armor { get; set; }

        public int Shield { get; set; }

        public int Speed { get; set; }

        public ModuleCategory Category { get; set; }

        public int Volley { get; set; }

        public int Range { get; set; }

        public int MissileSpeed { get; set; }

        public int Value { get; set; }

        public int Stealth { get; set; }

        public int Sensor { get; set; }

        public bool IsIllegal { get; set; }

        [JsonIgnore]
        public List<Starship> Starships { get; set; }
    }
}
