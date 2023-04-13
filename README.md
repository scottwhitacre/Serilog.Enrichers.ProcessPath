# Serilog.Enrichers.ProcessPath
 
 The process path enricher for Serilog.

 ## Usage
 ``` csharp
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .Enrich.WithProcessPath()
    .CreateLogger();
```
