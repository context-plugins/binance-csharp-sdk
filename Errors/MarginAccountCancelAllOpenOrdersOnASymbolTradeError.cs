using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class MarginAccountCancelAllOpenOrdersOnASymbolTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private MarginAccountCancelAllOpenOrdersOnASymbolTradeError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static MarginAccountCancelAllOpenOrdersOnASymbolTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static MarginAccountCancelAllOpenOrdersOnASymbolTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<MarginAccountCancelAllOpenOrdersOnASymbolTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MarginAccountCancelAllOpenOrdersOnASymbolTradeErrorResponse : IErrorResponse<MarginAccountCancelAllOpenOrdersOnASymbolTradeError>
{
    public static MarginAccountCancelAllOpenOrdersOnASymbolTradeErrorResponse Instance { get; } = new();

    private MarginAccountCancelAllOpenOrdersOnASymbolTradeErrorResponse()
    {
    }

    public Task<MarginAccountCancelAllOpenOrdersOnASymbolTradeError> Map(HttpResponseMessage response,
        CancellationToken ct) => MarginAccountCancelAllOpenOrdersOnASymbolTradeError.Create(response, ct);
}
