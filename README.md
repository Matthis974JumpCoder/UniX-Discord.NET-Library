# UniX Discord.NET Library
[![NuGet](https://img.shields.io/nuget/vpre/UniXDiscordDotNetLibrary.svg?maxAge=2592000?style=plastic)](https://www.nuget.org/packages/UniXDiscordDotNetLibrary)
[![MyGet](https://img.shields.io/myget/discord-net/vpre/Discord.Net.svg)](https://www.myget.org/feed/Packages/discord-net) 

An unofficial .NET Library for the Discord Client
>

## Installation
> Soon..

## Compiling
> In order to compile Discord.Net, you require the following:

### - Visual Studio
- [Visual Studio 2017](https://www.microsoft.com/net/core#windowsvs2017)
- [.NET Core SDK](https://www.microsoft.com/net/download/core)

> The .NET Core workload must be selected during Visual Studio installation.

### - Command Line
- [.NET Core SDK](https://www.microsoft.com/net/download/core)

## Known Issues
### Websocket
.NET Core 1.1 does not support WebSockets on Win7 and earlier. This issue has been fixed since the release of .NET Core 2.1. It is recommended to target .NET Core 2.1 or above for your project if you wish to run your bot on legacy platforms; alternatively, you may choose to install the [Discord.Net.Providers.WS4Net](https://www.nuget.org/packages/Discord.Net.Providers.WS4Net/) package.

## Documentation

- Read the official Discord.net's [documentation](https://github.com/RogueException/Discord.Net).
- Read the official [documentation](https://discordapp.com/developers/docs/reference) of the Discord API.
