using Api.Interfaces;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace ApiIsolated
{
    public class GetCircuits
    {
        private readonly ILogger _logger;
        private readonly IRepository _repository;

        public GetCircuits(ILoggerFactory loggerFactory, IRepository repository)
        {
            _logger = loggerFactory.CreateLogger<GetCircuits>();
            _repository = repository;
        }

        [Function("circuits")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.WriteAsJsonAsync(_repository.GetCircuits());

            return response;
        }

    }
}
