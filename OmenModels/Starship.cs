using OmenModels.Interfaces;
using System;
using System.Collections.Generic;

namespace OmenModels
{
    public class Starship : IGuidId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public StarshipHull Hull { get; set; }

        public StarshipClass StarshipClass { get; set; }

        public List<ShipModule>? Modules { get; set; }
    }
}
