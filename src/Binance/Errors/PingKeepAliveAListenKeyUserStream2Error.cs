using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class PingKeepAliveAListenKeyUserStream2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private PingKeepAliveAListenKeyUserStream2Error(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static PingKeepAliveAListenKeyUserStream2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static PingKeepAliveAListenKeyUserStream2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    private static Task<PingKeepAliveAListenKeyUserStream2Error> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<Error>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PingKeepAliveAListenKeyUserStream2Error> Response { get; } = new(Create);
}
