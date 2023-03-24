using BlazorApp.Shared.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApiIsolated
{
    public class GetDrivers
    {
        private readonly ILogger _logger;
        private readonly List<RaceDriver> _drivers = new List<RaceDriver>() {
                new RaceDriver {Name = "Max Verstappen", Aggressiveness = 95, Experience = 80, Pace = 99, Racecraft = 95 },
                new RaceDriver {Name = "Sergio Perez", Aggressiveness = 80, Experience = 85, Pace = 85, Racecraft = 90 },
                new RaceDriver {Name = "Fernando Alonso", Aggressiveness = 95, Experience = 99, Pace = 05, Racecraft = 95 },
                new RaceDriver {Name = "lance Stroll", Aggressiveness = 95, Experience = 80, Pace = 80, Racecraft = 70 },
                new RaceDriver {Name = "Lewis Hamilton", Aggressiveness = 85, Experience = 95, Pace = 90, Racecraft = 94 },
                new RaceDriver {Name = "George Russell", Aggressiveness = 80, Experience = 80, Pace = 92, Racecraft = 92 },
                new RaceDriver {Name = "Lando Norris", Aggressiveness = 80, Experience = 80, Pace = 92, Racecraft = 80 },
                new RaceDriver {Name = "Oscar Piastri", Aggressiveness = 75, Experience = 50, Pace = 80, Racecraft = 70 },
                new RaceDriver {Name = "Alexander Albon", Aggressiveness = 75, Experience = 70, Pace = 80, Racecraft = 75 },
                new RaceDriver {Name = "Logan Sargeant", Aggressiveness = 75, Experience = 50, Pace = 75, Racecraft = 60 },
                new RaceDriver {Name = "Charles Leclerc", Aggressiveness = 80, Experience = 80, Pace = 88, Racecraft = 85 },
                new RaceDriver {Name = "Carlos Sainz", Aggressiveness = 85, Experience = 80, Pace = 84, Racecraft = 80 },
                new RaceDriver {Name = "Kevin Magnussen", Aggressiveness = 90, Experience = 86, Pace = 80, Racecraft = 78 },
                new RaceDriver {Name = "Nico Hulkenberg", Aggressiveness = 65, Experience = 85, Pace = 75, Racecraft = 76 },
                new RaceDriver {Name = "Pierre Gastly", Aggressiveness = 65, Experience = 80, Pace = 75, Racecraft = 80 },
                new RaceDriver {Name = "Esteban Ocon", Aggressiveness = 80, Experience = 80, Pace = 75, Racecraft = 81 },
                new RaceDriver {Name = "Guanyu Zhou", Aggressiveness = 65, Experience = 65, Pace = 70, Racecraft = 74 },
                new RaceDriver {Name = "Valtteri Bottas", Aggressiveness = 65, Experience = 90, Pace = 78, Racecraft = 78 },
                new RaceDriver {Name = "Yuki Tsunoda", Aggressiveness = 80, Experience = 70, Pace = 75, Racecraft = 65 },
                new RaceDriver {Name = "Nyck de Vries", Aggressiveness = 65, Experience = 50, Pace = 70, Racecraft = 60 },
            };

        public GetDrivers(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<GetDrivers>();
        }

        [Function("drivers")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteAsJsonAsync(_drivers);

            return response;
        }

    }
}
