using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class CloseAListenKeyUserStreamError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CloseAListenKeyUserStreamError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CloseAListenKeyUserStreamError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CloseAListenKeyUserStreamError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CloseAListenKeyUserStreamError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CloseAListenKeyUserStreamErrorResponse : IErrorResponse<CloseAListenKeyUserStreamError>
{
    public static CloseAListenKeyUserStreamErrorResponse Instance { get; } = new();

    private CloseAListenKeyUserStreamErrorResponse()
    {
    }

    public Task<CloseAListenKeyUserStreamError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CloseAListenKeyUserStreamError.Create(response, ct);
}
