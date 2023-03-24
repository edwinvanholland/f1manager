using Api.Interfaces;
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
        private readonly IRepository _repository;


        public GetDrivers(ILoggerFactory loggerFactory, IRepository repository)
        {
            _logger = loggerFactory.CreateLogger<GetDrivers>();
            _repository = repository;
        }

        [Function("drivers")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteAsJsonAsync(_repository.GetDrivers());

            return response;
        }

    }
}
