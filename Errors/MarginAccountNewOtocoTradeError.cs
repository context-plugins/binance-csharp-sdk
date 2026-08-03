using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class MarginAccountNewOtocoTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private MarginAccountNewOtocoTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static MarginAccountNewOtocoTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static MarginAccountNewOtocoTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<MarginAccountNewOtocoTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MarginAccountNewOtocoTradeErrorResponse : IErrorResponse<MarginAccountNewOtocoTradeError>
{
    public static MarginAccountNewOtocoTradeErrorResponse Instance { get; } = new();

    private MarginAccountNewOtocoTradeErrorResponse()
    {
    }

    public Task<MarginAccountNewOtocoTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MarginAccountNewOtocoTradeError.Create(response, ct);
}
