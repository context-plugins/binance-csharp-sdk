using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class CloseAListenKeyUserStream2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CloseAListenKeyUserStream2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CloseAListenKeyUserStream2Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static CloseAListenKeyUserStream2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    private static Task<CloseAListenKeyUserStream2Error> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<Error>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<CloseAListenKeyUserStream2Error> Response { get; } = new(Create);
}
