# ChainMCP

ChainMCP is a .NET-based Model Context Protocol (MCP) server implementation that provides a set of tools for handling simple operations like echoing messages and retrieving the current date and time.

## Features

- Built on .NET 9
- Implements Model Context Protocol (MCP) server
- Uses standard I/O for server transport
- Includes two main tools:
  - `today_tool`: Returns the current date and time
  - `echo_day_tool`: Echoes back a provided message

## Prerequisites

- .NET 9.0 SDK or later
- ModelContextProtocol package (version 0.1.0-preview.12 or compatible)

## Installation

ChainMCP can be installed as an MCP server for applications like Claude Desktop or Visual Studio Code.

1. Install the tool globally using the .NET CLI:dotnet tool install --global chainmcp
   Or if you're installing from a local build:dotnet pack
dotnet tool install --global --add-source ./chainmcp/nupkg chainmcp
2. Configure your MCP client (Claude Desktop or VS Code):

   ### For Claude Desktop
   
   Add the following to your Claude Desktop MCP configuration:
{
     "tools": {
       "chainmcp": {
         "command": "chainmcp"
       }
     }
   }
   ### For Visual Studio Code
   
   Add the following to your VS Code MCP configuration:
 {
     "mcpServers": {
       "chainmcp": {
         "command": "chainmcp"
       }
     }
   }
To update the tool to a newer version:dotnet tool update --global chainmcp
To uninstall:dotnet tool uninstall --global chainmcp

## Usage

The application provides two main tools that can be called from your MCP-enabled application:

### Today Tool

Returns the current date and time.

### Echo Tool

Echoes back the provided message.

Note: The `today_tool` must be called before using the `echo_day_tool` to obtain the correct message to echo.

## Project Structure

- `Program.cs` - Main application entry point and server configuration
- `Tools/TodayTool.cs` - Implementation of the Today tool
- `Tools/EchoTool.cs` - Implementation of the Echo tool

## Dependencies

- Microsoft.Extensions.Hosting
- ModelContextProtocol

## Building and Running

To build and run the project locally:
dotnet run --project chainmcp

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Contributing

[Add contribution guidelines here]

## Support

[Add support information here]
