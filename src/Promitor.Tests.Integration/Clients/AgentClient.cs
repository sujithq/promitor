using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using GuardNet;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Promitor.Tests.Integration.Clients
{
    public class AgentClient
    {
        protected HttpClient HttpClient { get; }
        protected string AgentName{ get; }
        protected ILogger Logger { get; }

        public AgentClient(string agentName, string baseUrlConfigKey, IConfiguration configuration, ILogger logger)
        {
            Guard.NotNull(configuration, nameof(configuration));
            Guard.NotNull(logger, nameof(logger));

            var baseUrl = configuration[baseUrlConfigKey];
            logger.LogInformation("Base URL for {AgentName} is '{Url}'", agentName, baseUrl);

            AgentName = agentName;
            HttpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
            Logger = logger;
        }

        public async Task<HttpResponseMessage> GetHealthAsync()
        {
            return await GetAsync("/api/v1/health");
        }

        public async Task<HttpResponseMessage> GetSystemInfoAsync()
        {
            return await GetAsync("/api/v1/system");
        }

        protected async Task<HttpResponseMessage> GetAsync(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);

            var stopwatch = Stopwatch.StartNew();
            var response = await HttpClient.SendAsync(request);
            stopwatch.Stop();

            Logger.LogRequest(request, response, stopwatch.Elapsed);

            return response;
        }
    }
}