using OmenModels.Interfaces;

namespace OmenModels
{
    public class StarshipHull : IGuidId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Hitpoints { get; set; }

        public int Value { get; set; }

        public string SpecialAbility { get; set; }
    }
}
