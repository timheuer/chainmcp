using System.ComponentModel;
using ModelContextProtocol.Server;

namespace ChainMCP.Tools;

[McpServerToolType]
public class EchoTool
{
    [McpServerTool(Name = "echo_day_tool"), Description("Echoes the message back to the client.")]
    public static string Echo(string message) => $"Echo: {message}";
}