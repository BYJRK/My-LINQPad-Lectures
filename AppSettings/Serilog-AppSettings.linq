<Query Kind="Statements">
  <NuGetReference>Microsoft.Extensions.Configuration</NuGetReference>
  <NuGetReference>Microsoft.Extensions.Configuration.Binder</NuGetReference>
  <NuGetReference>Microsoft.Extensions.Configuration.Json</NuGetReference>
  <NuGetReference>Serilog</NuGetReference>
  <NuGetReference>Serilog.Settings.Configuration</NuGetReference>
  <NuGetReference>Serilog.Sinks.Console</NuGetReference>
  <Namespace>Microsoft.Extensions.Configuration</Namespace>
  <Namespace>Serilog</Namespace>
</Query>

var dir = Path.GetDirectoryName(Util.CurrentQueryPath);
var logfile = Path.Combine(dir!, "appsettings.json");

var config = new ConfigurationBuilder()
    .AddJsonFile(logfile, false)
    .Build();
    
var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(config)
    .CreateLogger();

var obj = new 
{
    Error = "error message",
    Interval = 500,
    Flag = false
};
logger.Information("@{obj}", obj);
logger.Warning("Warning message with no properties");

var ex = new InvalidOperationException("Task failed successfully :)");
logger.Error(ex, "Oops!");