using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class CancelAllOpenOrdersOnASymbolTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CancelAllOpenOrdersOnASymbolTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CancelAllOpenOrdersOnASymbolTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CancelAllOpenOrdersOnASymbolTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CancelAllOpenOrdersOnASymbolTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CancelAllOpenOrdersOnASymbolTradeErrorResponse : IErrorResponse<CancelAllOpenOrdersOnASymbolTradeError>
{
    public static CancelAllOpenOrdersOnASymbolTradeErrorResponse Instance { get; } = new();

    private CancelAllOpenOrdersOnASymbolTradeErrorResponse()
    {
    }

    public Task<CancelAllOpenOrdersOnASymbolTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CancelAllOpenOrdersOnASymbolTradeError.Create(response, ct);
}
