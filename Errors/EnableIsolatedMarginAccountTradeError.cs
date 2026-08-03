using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class EnableIsolatedMarginAccountTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EnableIsolatedMarginAccountTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EnableIsolatedMarginAccountTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static EnableIsolatedMarginAccountTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EnableIsolatedMarginAccountTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EnableIsolatedMarginAccountTradeErrorResponse : IErrorResponse<EnableIsolatedMarginAccountTradeError>
{
    public static EnableIsolatedMarginAccountTradeErrorResponse Instance { get; } = new();

    private EnableIsolatedMarginAccountTradeErrorResponse()
    {
    }

    public Task<EnableIsolatedMarginAccountTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EnableIsolatedMarginAccountTradeError.Create(response, ct);
}
