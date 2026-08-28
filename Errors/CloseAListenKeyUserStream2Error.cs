using System.Net.Http;
using System.Threading;
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

    private static CloseAListenKeyUserStream2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CloseAListenKeyUserStream2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CloseAListenKeyUserStream2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CloseAListenKeyUserStream2ErrorResponse : IErrorResponse<CloseAListenKeyUserStream2Error>
{
    public static CloseAListenKeyUserStream2ErrorResponse Instance { get; } = new();

    private CloseAListenKeyUserStream2ErrorResponse()
    {
    }

    public Task<CloseAListenKeyUserStream2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CloseAListenKeyUserStream2Error.Create(response, ct);
}
