namespace Serilog.Enrichers.ProcessPath;
using Serilog;
using Serilog.Configuration;

public static class LoggingExtensions
{
    public static LoggerConfiguration WithProcessPath(this LoggerEnrichmentConfiguration enrich)
    {
        return enrich.With<ProcessPathEnricher>();
    }
}
