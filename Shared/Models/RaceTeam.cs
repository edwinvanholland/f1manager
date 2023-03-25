using System.Collections.Generic;

namespace BlazorApp.Shared.Models
{
    public class RaceTeam
    {
        public string Name { get; set; }
        public int Engine { get; set; }
        public int Aero { get; set; }
        public int Chassis { get; set; }
        public int Durability { get; set; }

        public double Rating => (double)((Engine+Aero+Chassis)/3);

        public List<RaceDriver> Drivers { get; set; } = new List<RaceDriver>();

        public int Points { get; set; }
    }
}
