using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class WrapBethTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private WrapBethTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static WrapBethTradeError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static WrapBethTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<WrapBethTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class WrapBethTradeErrorResponse : IErrorResponse<WrapBethTradeError>
{
    public static WrapBethTradeErrorResponse Instance { get; } = new();

    private WrapBethTradeErrorResponse()
    {
    }

    public Task<WrapBethTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        WrapBethTradeError.Create(response, ct);
}
