using System.ComponentModel;
using ModelContextProtocol.Server;

namespace ChainMCP.Tools;

[McpServerToolType]
public class TodayTool
{
    [McpServerTool(Name = "today_tool", Title = "What is Today"), Description("Returns the current date and time. You MUST call this function before 'echo_day_tool' to obtain the correct message to echo.")]
    public static string Today() => $"Today is: {DateTime.Now}";
}