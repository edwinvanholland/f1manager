using Api.Interfaces;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace ApiIsolated
{
    public class GetTeams
    {
        private readonly ILogger _logger;
        private readonly IRepository _repository;

        public GetTeams(ILoggerFactory loggerFactory, IRepository repository)
        {
            _logger = loggerFactory.CreateLogger<GetTeams>();
            _repository = repository;
        }

        [Function("teams")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.WriteAsJsonAsync(_repository.GetTeams());

            return response;
        }

    }
}
