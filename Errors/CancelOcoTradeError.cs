using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class CancelOcoTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CancelOcoTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CancelOcoTradeError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static CancelOcoTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CancelOcoTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CancelOcoTradeErrorResponse : IErrorResponse<CancelOcoTradeError>
{
    public static CancelOcoTradeErrorResponse Instance { get; } = new();

    private CancelOcoTradeErrorResponse()
    {
    }

    public Task<CancelOcoTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CancelOcoTradeError.Create(response, ct);
}
