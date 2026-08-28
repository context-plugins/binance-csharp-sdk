using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class MarginAccountNewOcoTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private MarginAccountNewOcoTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static MarginAccountNewOcoTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static MarginAccountNewOcoTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<MarginAccountNewOcoTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MarginAccountNewOcoTradeErrorResponse : IErrorResponse<MarginAccountNewOcoTradeError>
{
    public static MarginAccountNewOcoTradeErrorResponse Instance { get; } = new();

    private MarginAccountNewOcoTradeErrorResponse()
    {
    }

    public Task<MarginAccountNewOcoTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MarginAccountNewOcoTradeError.Create(response, ct);
}
