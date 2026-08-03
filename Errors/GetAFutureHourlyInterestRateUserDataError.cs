using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetAFutureHourlyInterestRateUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAFutureHourlyInterestRateUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAFutureHourlyInterestRateUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAFutureHourlyInterestRateUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAFutureHourlyInterestRateUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAFutureHourlyInterestRateUserDataErrorResponse : IErrorResponse<GetAFutureHourlyInterestRateUserDataError>
{
    public static GetAFutureHourlyInterestRateUserDataErrorResponse Instance { get; } = new();

    private GetAFutureHourlyInterestRateUserDataErrorResponse()
    {
    }

    public Task<GetAFutureHourlyInterestRateUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAFutureHourlyInterestRateUserDataError.Create(response, ct);
}
