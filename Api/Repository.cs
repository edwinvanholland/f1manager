using Api.Interfaces;
using BlazorApp.Shared.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Api
{
    public class Repository : IRepository
    {
        private readonly List<RaceTeam> _teams;
        private readonly List<Circuit> _circuits;

        public Repository()
        {
            _teams = new List<RaceTeam>() {
                        new RaceTeam {
                            Name = "Red Bull", Aero = 95, Engine = 90, Durability = 80, Chassis = 95,
                            Drivers = new() {
                              new RaceDriver {Name = "Max Verstappen", Aggressiveness = 95, Experience = 80, Pace = 99, Racecraft = 95 },
                              new RaceDriver {Name = "Sergio Perez", Aggressiveness = 80, Experience = 85, Pace = 85, Racecraft = 90 },  }
                        },
                        new RaceTeam {Name = "Aston Martin", Aero = 90, Engine = 90, Durability = 90, Chassis = 90,
                            Drivers = new() {
                                new RaceDriver {Name = "Fernando Alonso", Aggressiveness = 95, Experience = 99, Pace = 05, Racecraft = 95 },
                                new RaceDriver {Name = "lance Stroll", Aggressiveness = 95, Experience = 80, Pace = 80, Racecraft = 70 }
                            }
                        },
                        new RaceTeam {Name = "Mercedes", Aero = 80, Engine = 88, Durability = 90, Chassis = 65,
                            Drivers = new() {
                                new RaceDriver {Name = "Lewis Hamilton", Aggressiveness = 85, Experience = 95, Pace = 90, Racecraft = 94 },
                                new RaceDriver {Name = "George Russell", Aggressiveness = 80, Experience = 80, Pace = 92, Racecraft = 92 }
                            }
                        },
                        new RaceTeam {Name = "Ferrari", Aero = 90, Engine = 95, Durability = 80, Chassis = 85,
                           Drivers = new() {
                                new RaceDriver {Name = "Charles Leclerc", Aggressiveness = 80, Experience = 80, Pace = 88, Racecraft = 85 },
                                new RaceDriver {Name = "Carlos Sainz", Aggressiveness = 85, Experience = 80, Pace = 84, Racecraft = 80 }
                            }
                        },
                        new RaceTeam {Name = "McLaren", Aero = 60, Engine = 88, Durability = 70, Chassis = 55,
                               Drivers = new() {
                                    new RaceDriver {Name = "Lando Norris", Aggressiveness = 80, Experience = 80, Pace = 92, Racecraft = 80 },
                                    new RaceDriver {Name = "Oscar Piastri", Aggressiveness = 75, Experience = 50, Pace = 80, Racecraft = 70 }
                            }
                        },
                        new RaceTeam {Name = "Alpine", Aero = 80, Engine = 87, Durability = 80, Chassis = 75,
                               Drivers = new() {
                                    new RaceDriver {Name = "Pierre Gastly", Aggressiveness = 65, Experience = 80, Pace = 75, Racecraft = 80 },
                                    new RaceDriver {Name = "Esteban Ocon", Aggressiveness = 80, Experience = 80, Pace = 75, Racecraft = 81 }
                            }
                        },
                        new RaceTeam {Name = "Alpha Tauri", Aero = 82, Engine = 90, Durability = 80, Chassis = 65,
                                Drivers = new() {
                                    new RaceDriver {Name = "Yuki Tsunoda", Aggressiveness = 80, Experience = 70, Pace = 75, Racecraft = 65 },
                                    new RaceDriver {Name = "Nyck de Vries", Aggressiveness = 65, Experience = 50, Pace = 70, Racecraft = 60 }
                            }
                        },
                        new RaceTeam {Name = "Williams", Aero = 85, Engine = 88, Durability = 85, Chassis = 75,
                                Drivers = new() {
                                    new RaceDriver {Name = "Alexander Albon", Aggressiveness = 75, Experience = 70, Pace = 80, Racecraft = 75 },
                                    new RaceDriver {Name = "Logan Sargeant", Aggressiveness = 75, Experience = 50, Pace = 75, Racecraft = 60 }
                            }
                        },
                        new RaceTeam {Name = "Alfa Romeo", Aero = 78, Engine = 95, Durability = 80, Chassis = 70,
                               Drivers = new() {
                                    new RaceDriver {Name = "Guanyu Zhou", Aggressiveness = 65, Experience = 65, Pace = 70, Racecraft = 74 },
                                    new RaceDriver {Name = "Valtteri Bottas", Aggressiveness = 65, Experience = 90, Pace = 78, Racecraft = 78 }
                            }
                        },
                        new RaceTeam {Name = "Haas", Aero = 83, Engine = 95, Durability = 80, Chassis = 75,
                                Drivers = new() {
                                    new RaceDriver {Name = "Kevin Magnussen", Aggressiveness = 90, Experience = 86, Pace = 80, Racecraft = 78 },
                                    new RaceDriver {Name = "Nico Hulkenberg", Aggressiveness = 65, Experience = 85, Pace = 75, Racecraft = 76 }
                            }
                        }
                    };

            _circuits = new List<Circuit>
            {
                new Circuit{ Name = "Bahrain International", AeroFactor = 90, Country = "Bahrain", ChassisFactor = 50, EngineFactor = 90, OptimalLaptimeMs = 90000}
            };
        }

        public List<Circuit> GetCircuits()
        {
            return _circuits;
        }

        public List<RaceDriver> GetDrivers()
        {

            var result = new List<RaceDriver>();
            foreach (var team in _teams)
            {
                result.AddRange(team.Drivers);
            }
            return result;

        }

        public List<RaceTeam> GetTeams() => _teams;

    }
}
