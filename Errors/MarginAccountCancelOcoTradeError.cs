using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class MarginAccountCancelOcoTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private MarginAccountCancelOcoTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static MarginAccountCancelOcoTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static MarginAccountCancelOcoTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<MarginAccountCancelOcoTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MarginAccountCancelOcoTradeErrorResponse : IErrorResponse<MarginAccountCancelOcoTradeError>
{
    public static MarginAccountCancelOcoTradeErrorResponse Instance { get; } = new();

    private MarginAccountCancelOcoTradeErrorResponse()
    {
    }

    public Task<MarginAccountCancelOcoTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MarginAccountCancelOcoTradeError.Create(response, ct);
}
