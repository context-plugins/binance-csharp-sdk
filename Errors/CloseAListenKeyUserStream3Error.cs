using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class CloseAListenKeyUserStream3Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CloseAListenKeyUserStream3Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CloseAListenKeyUserStream3Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CloseAListenKeyUserStream3Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CloseAListenKeyUserStream3Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CloseAListenKeyUserStream3ErrorResponse : IErrorResponse<CloseAListenKeyUserStream3Error>
{
    public static CloseAListenKeyUserStream3ErrorResponse Instance { get; } = new();

    private CloseAListenKeyUserStream3ErrorResponse()
    {
    }

    public Task<CloseAListenKeyUserStream3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CloseAListenKeyUserStream3Error.Create(response, ct);
}
