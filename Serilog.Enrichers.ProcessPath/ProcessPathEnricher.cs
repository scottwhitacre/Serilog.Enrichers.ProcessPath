using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers.ProcessPath;

public class ProcessPathEnricher : ILogEventEnricher
{
    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
    {
        logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty("ProcessPath", Environment.ProcessPath));
    }
}