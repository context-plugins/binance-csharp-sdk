using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetPayTradeHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetPayTradeHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetPayTradeHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetPayTradeHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetPayTradeHistoryUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPayTradeHistoryUserDataErrorResponse : IErrorResponse<GetPayTradeHistoryUserDataError>
{
    public static GetPayTradeHistoryUserDataErrorResponse Instance { get; } = new();

    private GetPayTradeHistoryUserDataErrorResponse()
    {
    }

    public Task<GetPayTradeHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPayTradeHistoryUserDataError.Create(response, ct);
}
