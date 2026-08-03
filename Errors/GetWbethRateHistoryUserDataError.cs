using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetWbethRateHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetWbethRateHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetWbethRateHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetWbethRateHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetWbethRateHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetWbethRateHistoryUserDataErrorResponse : IErrorResponse<GetWbethRateHistoryUserDataError>
{
    public static GetWbethRateHistoryUserDataErrorResponse Instance { get; } = new();

    private GetWbethRateHistoryUserDataErrorResponse()
    {
    }

    public Task<GetWbethRateHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetWbethRateHistoryUserDataError.Create(response, ct);
}
