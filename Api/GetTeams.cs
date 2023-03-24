using BlazorApp.Shared.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ApiIsolated
{
    public class GetTeams
    {
        private readonly ILogger _logger;
        private readonly List<RaceTeam> _raceTeams = new List<RaceTeam>() {
                new RaceTeam {Name = "Red Bull", Aero = 95, Engine = 90, Durability = 80, Chassis = 95 },
                new RaceTeam {Name = "Aston Martin", Aero = 90, Engine = 90, Durability = 90, Chassis = 90 },
                new RaceTeam {Name = "Mercedes", Aero = 80, Engine = 88, Durability = 90, Chassis = 65 },
                new RaceTeam {Name = "Ferrari", Aero = 90, Engine = 95, Durability = 80, Chassis = 85 },
                new RaceTeam {Name = "McLaren", Aero = 60, Engine = 88, Durability = 70, Chassis = 55 },
                new RaceTeam {Name = "Alpine", Aero = 80, Engine = 87, Durability = 80, Chassis = 75 },
                new RaceTeam {Name = "Alpha Tauri", Aero = 82, Engine = 90, Durability = 80, Chassis = 65 },
                new RaceTeam {Name = "Williams", Aero = 85, Engine = 88, Durability = 85, Chassis = 75 },
                new RaceTeam {Name = "Alfa Romeo", Aero = 78, Engine = 95, Durability = 80, Chassis = 70 },
                new RaceTeam {Name = "Haas", Aero = 83, Engine = 95, Durability = 80, Chassis = 75 },
            };

        public GetTeams(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<GetTeams>();
        }

        [Function("teams")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.WriteAsJsonAsync(_raceTeams.ToArray());

            return response;
        }

    }
}
