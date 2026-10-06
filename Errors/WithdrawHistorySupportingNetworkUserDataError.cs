using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class WithdrawHistorySupportingNetworkUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private WithdrawHistorySupportingNetworkUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static WithdrawHistorySupportingNetworkUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static WithdrawHistorySupportingNetworkUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    private static Task<WithdrawHistorySupportingNetworkUserDataError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 => response.Json<Error>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<WithdrawHistorySupportingNetworkUserDataError> Response { get; } = new(Create);
}
