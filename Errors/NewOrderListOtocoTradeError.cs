using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class NewOrderListOtocoTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private NewOrderListOtocoTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static NewOrderListOtocoTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static NewOrderListOtocoTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<NewOrderListOtocoTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class NewOrderListOtocoTradeErrorResponse : IErrorResponse<NewOrderListOtocoTradeError>
{
    public static NewOrderListOtocoTradeErrorResponse Instance { get; } = new();

    private NewOrderListOtocoTradeErrorResponse()
    {
    }

    public Task<NewOrderListOtocoTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        NewOrderListOtocoTradeError.Create(response, ct);
}
