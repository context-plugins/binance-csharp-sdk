using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class CancelOrderTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CancelOrderTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CancelOrderTradeError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static CancelOrderTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CancelOrderTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CancelOrderTradeErrorResponse : IErrorResponse<CancelOrderTradeError>
{
    public static CancelOrderTradeErrorResponse Instance { get; } = new();

    private CancelOrderTradeErrorResponse()
    {
    }

    public Task<CancelOrderTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CancelOrderTradeError.Create(response, ct);
}
