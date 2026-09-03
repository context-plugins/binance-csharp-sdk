using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class SymbolOrderBookTickerError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SymbolOrderBookTickerError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SymbolOrderBookTickerError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SymbolOrderBookTickerError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SymbolOrderBookTickerError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SymbolOrderBookTickerErrorResponse : IErrorResponse<SymbolOrderBookTickerError>
{
    public static SymbolOrderBookTickerErrorResponse Instance { get; } = new();

    private SymbolOrderBookTickerErrorResponse()
    {
    }

    public Task<SymbolOrderBookTickerError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SymbolOrderBookTickerError.Create(response, ct);
}
