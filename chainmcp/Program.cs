using ChainMCP.Tools;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddMcpServer()
    .WithStdioServerTransport()
    .WithTools<TodayTool>()
    .WithTools<EchoTool>();

builder.Logging.ClearProviders();
builder.Logging.AddConsole(options =>
{
    options.LogToStandardErrorThreshold = LogLevel.Trace;
});

await builder.Build().RunAsync();