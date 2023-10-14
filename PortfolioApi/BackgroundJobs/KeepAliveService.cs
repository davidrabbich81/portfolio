using System.Net;

namespace PortfolioApi.BackgroundJobs
{
    public class KeepAliveService : BackgroundService, IDisposable
    {
        private int executionCount = 0;
        private readonly ILogger<KeepAliveService> _logger;
        private Timer? _timer = null;

        public KeepAliveService(ILogger<KeepAliveService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var timer = new PeriodicTimer(TimeSpan.FromMinutes(10));
            while (await timer.WaitForNextTickAsync(stoppingToken))
            {
                await CallKeepAliveEndpoint();
            }
        }

        /// <summary>
        /// Calls the keep alive endpoint to keep the site running
        /// </summary>
        /// <returns></returns>
        private async Task CallKeepAliveEndpoint()
        {
#if DEBUG
            var host = "https://localhost:7214";
#else
            var host = "https://rabbich.dev";
#endif

            HttpClientHandler httpClientHandler = new HttpClientHandler();
            httpClientHandler.AllowAutoRedirect = false;

            using (HttpClient client = new HttpClient(httpClientHandler))
            {
                await client.GetAsync($"{host}/api/KeepAlive");
                _logger.LogInformation("Keep alive Url was called");
            }
        }

    }
}
