using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class FiatPaymentsHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FiatPaymentsHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FiatPaymentsHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static FiatPaymentsHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FiatPaymentsHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FiatPaymentsHistoryUserDataErrorResponse : IErrorResponse<FiatPaymentsHistoryUserDataError>
{
    public static FiatPaymentsHistoryUserDataErrorResponse Instance { get; } = new();

    private FiatPaymentsHistoryUserDataErrorResponse()
    {
    }

    public Task<FiatPaymentsHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        FiatPaymentsHistoryUserDataError.Create(response, ct);
}
