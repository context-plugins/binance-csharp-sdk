using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class SubscribeLockedProductTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubscribeLockedProductTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubscribeLockedProductTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubscribeLockedProductTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubscribeLockedProductTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubscribeLockedProductTradeErrorResponse : IErrorResponse<SubscribeLockedProductTradeError>
{
    public static SubscribeLockedProductTradeErrorResponse Instance { get; } = new();

    private SubscribeLockedProductTradeErrorResponse()
    {
    }

    public Task<SubscribeLockedProductTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SubscribeLockedProductTradeError.Create(response, ct);
}
