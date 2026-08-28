using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class MarginAccountCancelOrderTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private MarginAccountCancelOrderTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static MarginAccountCancelOrderTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static MarginAccountCancelOrderTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<MarginAccountCancelOrderTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MarginAccountCancelOrderTradeErrorResponse : IErrorResponse<MarginAccountCancelOrderTradeError>
{
    public static MarginAccountCancelOrderTradeErrorResponse Instance { get; } = new();

    private MarginAccountCancelOrderTradeErrorResponse()
    {
    }

    public Task<MarginAccountCancelOrderTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MarginAccountCancelOrderTradeError.Create(response, ct);
}
