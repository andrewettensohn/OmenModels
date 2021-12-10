using System;

namespace OmenModels
{
    public class StarshipClass
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Slots { get; set; }

        public int BaseStealth { get; set; }
    }
}
