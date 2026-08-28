using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class NewOrderListOtoTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private NewOrderListOtoTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static NewOrderListOtoTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static NewOrderListOtoTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<NewOrderListOtoTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class NewOrderListOtoTradeErrorResponse : IErrorResponse<NewOrderListOtoTradeError>
{
    public static NewOrderListOtoTradeErrorResponse Instance { get; } = new();

    private NewOrderListOtoTradeErrorResponse()
    {
    }

    public Task<NewOrderListOtoTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        NewOrderListOtoTradeError.Create(response, ct);
}
