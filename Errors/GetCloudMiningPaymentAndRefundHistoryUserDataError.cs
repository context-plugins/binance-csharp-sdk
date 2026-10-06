using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetCloudMiningPaymentAndRefundHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetCloudMiningPaymentAndRefundHistoryUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetCloudMiningPaymentAndRefundHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetCloudMiningPaymentAndRefundHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    private static Task<GetCloudMiningPaymentAndRefundHistoryUserDataError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 => response.Json<Error>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetCloudMiningPaymentAndRefundHistoryUserDataError> Response { get; } = new(
        Create);
}
