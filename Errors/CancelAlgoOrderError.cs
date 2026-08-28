using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class CancelAlgoOrderError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CancelAlgoOrderError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CancelAlgoOrderError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static CancelAlgoOrderError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CancelAlgoOrderError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CancelAlgoOrderErrorResponse : IErrorResponse<CancelAlgoOrderError>
{
    public static CancelAlgoOrderErrorResponse Instance { get; } = new();

    private CancelAlgoOrderErrorResponse()
    {
    }

    public Task<CancelAlgoOrderError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CancelAlgoOrderError.Create(response, ct);
}
