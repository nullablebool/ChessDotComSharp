<img src="https://upload.wikimedia.org/wikipedia/en/7/75/Chess.com_logo_%28new%29.png" width="350" />

# Chess.com Unofficial API

A .NET wrapper for [Chess.com](https://chess.com)'s API. This project is using the .NET Core 2.0 framework.

## Getting Started
Download or clone the repo and build. Or, use Nuget...

### Install via Nuget

To install via Nuget, simply run...

```
Install-Package ChessDotComSharp
```

## Usage

Easy to use with fully typed models:

```cs
var client = new ChessDotComClient();
var myGames = await client.GetPlayerGamesAsync("kgooding");
```

### Full API documentation

The full documentation of [Chess.com](https://chess.com)'s API can be found at [https://www.chess.com/news/view/published-data-api](https://www.chess.com/news/view/published-data-api)

## Built With

* [.NET Core 2.0](https://github.com/dotnet/core/) - .NET Core 2.0

## Contributing

Contributions welcome, would like to stub out the service and add unit tests.

## Authors

* **nullablebool** - *Initial work* - [nullablebool](https://github.com/nullablebool)

See also the list of [contributors](https://github.com/nullablebool/ChessDotComSharp/contributors) who participated in this project.

## Acknowledgments

* Chess.com Team
