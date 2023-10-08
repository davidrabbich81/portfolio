namespace PortfolioApi.BackgroundJobs
{
    public class KeepAliveService : IHostedService, IDisposable
    {
        private int executionCount = 0;
        private readonly ILogger<KeepAliveService> _logger;
        private Timer? _timer = null;

        public KeepAliveService(ILogger<KeepAliveService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            // run a basic job every 10 minutes
            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromMinutes(10));

            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            var count = Interlocked.Increment(ref executionCount);

            _logger.LogInformation(
                "Timed Hosted Service is working. Count: {Count}", count);
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
