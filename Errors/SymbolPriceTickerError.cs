using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class SymbolPriceTickerError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SymbolPriceTickerError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SymbolPriceTickerError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static SymbolPriceTickerError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SymbolPriceTickerError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SymbolPriceTickerErrorResponse : IErrorResponse<SymbolPriceTickerError>
{
    public static SymbolPriceTickerErrorResponse Instance { get; } = new();

    private SymbolPriceTickerErrorResponse()
    {
    }

    public Task<SymbolPriceTickerError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SymbolPriceTickerError.Create(response, ct);
}
