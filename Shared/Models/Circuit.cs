namespace BlazorApp.Shared.Models
{
    public class Circuit
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int EngineFactor { get; set; }
        public int AeroFactor { get; set; }
        public int ChassicFactor { get; set; }
        public int OptimalLaptimeMs { get; set; }
    }
}
