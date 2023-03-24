namespace BlazorApp.Shared.Models
{
    public class RaceTeam
    {
        public string Name { get; set; }
        public int Engine { get; set; }
        public int Aero { get; set; }
        public int Chassis { get; set; }
        public int Durability { get; set; }

        public int Rating => ((Engine+Aero+Chassis)/3);
    }
}
