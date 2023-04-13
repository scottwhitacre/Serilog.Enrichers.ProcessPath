namespace Serilog.Enrichers.ProcessPath.Tests;

public class ProcessNameEnricherTests
{
    [Fact]
    public void ProcessNameEnricherIsApplied()
    {
        LogEvent? evt = null;
        var log = new LoggerConfiguration()
            .Enrich.WithProcessPath()
            .WriteTo.Sink(new DelegatingSink(e => evt = e))
            .CreateLogger();

        log.Information(@"Has a ProcessPath property");

        Assert.NotNull(evt);

        var processPath = Environment.ProcessPath;
        Assert.Equal(processPath, (string?)evt?.Properties["ProcessPath"]?.LiteralValue());
    }
}
