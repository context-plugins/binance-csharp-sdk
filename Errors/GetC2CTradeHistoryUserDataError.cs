using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetC2CTradeHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetC2CTradeHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetC2CTradeHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetC2CTradeHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetC2CTradeHistoryUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetC2CTradeHistoryUserDataErrorResponse : IErrorResponse<GetC2CTradeHistoryUserDataError>
{
    public static GetC2CTradeHistoryUserDataErrorResponse Instance { get; } = new();

    private GetC2CTradeHistoryUserDataErrorResponse()
    {
    }

    public Task<GetC2CTradeHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetC2CTradeHistoryUserDataError.Create(response, ct);
}
