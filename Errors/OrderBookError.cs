using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class OrderBookError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private OrderBookError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static OrderBookError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static OrderBookError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<OrderBookError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OrderBookErrorResponse : IErrorResponse<OrderBookError>
{
    public static OrderBookErrorResponse Instance { get; } = new();

    private OrderBookErrorResponse()
    {
    }

    public Task<OrderBookError> Map(HttpResponseMessage response, CancellationToken ct) =>
        OrderBookError.Create(response, ct);
}
