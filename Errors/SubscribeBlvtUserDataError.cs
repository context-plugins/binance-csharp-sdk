using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class SubscribeBlvtUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubscribeBlvtUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubscribeBlvtUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubscribeBlvtUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubscribeBlvtUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubscribeBlvtUserDataErrorResponse : IErrorResponse<SubscribeBlvtUserDataError>
{
    public static SubscribeBlvtUserDataErrorResponse Instance { get; } = new();

    private SubscribeBlvtUserDataErrorResponse()
    {
    }

    public Task<SubscribeBlvtUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SubscribeBlvtUserDataError.Create(response, ct);
}
