using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class OrderStatusUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private OrderStatusUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static OrderStatusUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static OrderStatusUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<OrderStatusUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OrderStatusUserDataErrorResponse : IErrorResponse<OrderStatusUserDataError>
{
    public static OrderStatusUserDataErrorResponse Instance { get; } = new();

    private OrderStatusUserDataErrorResponse()
    {
    }

    public Task<OrderStatusUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        OrderStatusUserDataError.Create(response, ct);
}
