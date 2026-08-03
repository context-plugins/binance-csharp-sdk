# Binance Public Spot API

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The Binance Public Spot API SDK for .NET provides access to the Binance Public Spot API REST APIs from .NET applications.

OpenAPI Specifications for the Binance Public Spot API

API documents:
  - [https://github.com/binance/binance-spot-api-docs](https://github.com/binance/binance-spot-api-docs)
  - [https://binance-docs.github.io/apidocs/spot/en](https://binance-docs.github.io/apidocs/spot/en)

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/BinancePublicSpotApi.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [BinancePublicSpotApiClientOptions](BinancePublicSpotApiClientOptions.cs).

```csharp
services.AddBinancePublicSpotApiClient(options =>
    {
        options.ApiKeyAuth = "YOUR_API_KEY";
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [BinancePublicSpotApiClientOptions](BinancePublicSpotApiClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new BinancePublicSpotApiClientOptions
    {
        ApiKeyAuth = "YOUR_API_KEY",
        Environment = ServerEnvironment.Production,
    };
var client = new BinancePublicSpotApiClient(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## Best Practices

> [!TIP]
> Use a **single `BinancePublicSpotApiClient` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
