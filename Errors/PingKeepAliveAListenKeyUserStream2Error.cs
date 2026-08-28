using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class PingKeepAliveAListenKeyUserStream2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private PingKeepAliveAListenKeyUserStream2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static PingKeepAliveAListenKeyUserStream2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static PingKeepAliveAListenKeyUserStream2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<PingKeepAliveAListenKeyUserStream2Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PingKeepAliveAListenKeyUserStream2ErrorResponse : IErrorResponse<PingKeepAliveAListenKeyUserStream2Error>
{
    public static PingKeepAliveAListenKeyUserStream2ErrorResponse Instance { get; } = new();

    private PingKeepAliveAListenKeyUserStream2ErrorResponse()
    {
    }

    public Task<PingKeepAliveAListenKeyUserStream2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        PingKeepAliveAListenKeyUserStream2Error.Create(response, ct);
}
