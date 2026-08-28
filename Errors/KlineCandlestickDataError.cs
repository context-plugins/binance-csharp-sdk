using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class KlineCandlestickDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private KlineCandlestickDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static KlineCandlestickDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static KlineCandlestickDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<KlineCandlestickDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class KlineCandlestickDataErrorResponse : IErrorResponse<KlineCandlestickDataError>
{
    public static KlineCandlestickDataErrorResponse Instance { get; } = new();

    private KlineCandlestickDataErrorResponse()
    {
    }

    public Task<KlineCandlestickDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        KlineCandlestickDataError.Create(response, ct);
}
