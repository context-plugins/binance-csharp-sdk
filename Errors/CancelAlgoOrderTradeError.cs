using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class CancelAlgoOrderTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CancelAlgoOrderTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CancelAlgoOrderTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CancelAlgoOrderTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CancelAlgoOrderTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CancelAlgoOrderTradeErrorResponse : IErrorResponse<CancelAlgoOrderTradeError>
{
    public static CancelAlgoOrderTradeErrorResponse Instance { get; } = new();

    private CancelAlgoOrderTradeErrorResponse()
    {
    }

    public Task<CancelAlgoOrderTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CancelAlgoOrderTradeError.Create(response, ct);
}
