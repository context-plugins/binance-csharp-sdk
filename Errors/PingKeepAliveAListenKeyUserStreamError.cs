using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class PingKeepAliveAListenKeyUserStreamError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private PingKeepAliveAListenKeyUserStreamError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static PingKeepAliveAListenKeyUserStreamError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static PingKeepAliveAListenKeyUserStreamError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<PingKeepAliveAListenKeyUserStreamError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PingKeepAliveAListenKeyUserStreamErrorResponse : IErrorResponse<PingKeepAliveAListenKeyUserStreamError>
{
    public static PingKeepAliveAListenKeyUserStreamErrorResponse Instance { get; } = new();

    private PingKeepAliveAListenKeyUserStreamErrorResponse()
    {
    }

    public Task<PingKeepAliveAListenKeyUserStreamError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PingKeepAliveAListenKeyUserStreamError.Create(response, ct);
}
