using System;
using System.Collections.Generic;

namespace OmenModels
{
    public class Starship
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Hitpoints { get; set; }

        public int Value { get; set; }

        public string SpecialAbility { get; set; }

        public StarshipClass StarshipClass { get; set; }

        public List<ShipModule> Modules { get; set; }
    }
}
