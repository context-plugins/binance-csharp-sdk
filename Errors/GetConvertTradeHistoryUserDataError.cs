using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetConvertTradeHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetConvertTradeHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetConvertTradeHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetConvertTradeHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetConvertTradeHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetConvertTradeHistoryUserDataErrorResponse : IErrorResponse<GetConvertTradeHistoryUserDataError>
{
    public static GetConvertTradeHistoryUserDataErrorResponse Instance { get; } = new();

    private GetConvertTradeHistoryUserDataErrorResponse()
    {
    }

    public Task<GetConvertTradeHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetConvertTradeHistoryUserDataError.Create(response, ct);
}
