# Serilog.Enrichers.ProcessPath
 
 The process path enricher for Serilog.

![Build](https://github.com/scottwhitacre/Serilog.Enrichers.ProcessPath/actions/workflows/build.yml/badge.svg)

 ## Usage
 ``` csharp
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .Enrich.WithProcessPath()
    .CreateLogger();
```
