namespace Serilog.Enrichers.ProcessPath.Tests;

public static class Extensions
{
    public static object? LiteralValue(this LogEventPropertyValue @this) =>
        ((ScalarValue)@this).Value;
}