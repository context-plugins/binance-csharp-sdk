using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class NewOrderListOcoTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private NewOrderListOcoTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static NewOrderListOcoTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static NewOrderListOcoTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<NewOrderListOcoTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class NewOrderListOcoTradeErrorResponse : IErrorResponse<NewOrderListOcoTradeError>
{
    public static NewOrderListOcoTradeErrorResponse Instance { get; } = new();

    private NewOrderListOcoTradeErrorResponse()
    {
    }

    public Task<NewOrderListOcoTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        NewOrderListOcoTradeError.Create(response, ct);
}
