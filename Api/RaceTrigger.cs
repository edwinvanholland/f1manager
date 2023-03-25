using Api.Interfaces;
using BlazorApp.Shared.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ApiIsolated
{
    public class RaceTrigger
    {
        private readonly ILogger _logger;
        private readonly IRepository _repository;

        public RaceTrigger(ILoggerFactory loggerFactory, IRepository repository)
        {
            _logger = loggerFactory.CreateLogger<RaceTrigger>();
            _repository = repository;
        }

        [Function("race")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            var payload = await req.ReadFromJsonAsync<List<QualifyResult>>();
            _repository.UpdateRaceStats(payload);

            return response;
        }

    }
}
