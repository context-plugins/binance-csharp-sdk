using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class DisableIsolatedMarginAccountTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DisableIsolatedMarginAccountTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DisableIsolatedMarginAccountTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DisableIsolatedMarginAccountTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DisableIsolatedMarginAccountTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DisableIsolatedMarginAccountTradeErrorResponse : IErrorResponse<DisableIsolatedMarginAccountTradeError>
{
    public static DisableIsolatedMarginAccountTradeErrorResponse Instance { get; } = new();

    private DisableIsolatedMarginAccountTradeErrorResponse()
    {
    }

    public Task<DisableIsolatedMarginAccountTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DisableIsolatedMarginAccountTradeError.Create(response, ct);
}
