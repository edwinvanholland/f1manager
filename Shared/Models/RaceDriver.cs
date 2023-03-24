namespace BlazorApp.Shared.Models
{
    public class RaceDriver
    {
        public string Name { get; set; }
        public RaceTeam Team { get; set; }
        public int Pace { get; set; }
        public int Racecraft { get; set; }
        public int Experience { get; set; }
        public int Aggressiveness { get; set; }

        public int Rating => ((Pace + Racecraft + Experience + Aggressiveness) / 4);
    }
}
