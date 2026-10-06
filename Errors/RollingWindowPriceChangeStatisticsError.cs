using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class RollingWindowPriceChangeStatisticsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RollingWindowPriceChangeStatisticsError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RollingWindowPriceChangeStatisticsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RollingWindowPriceChangeStatisticsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    private static Task<RollingWindowPriceChangeStatisticsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<Error>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<RollingWindowPriceChangeStatisticsError> Response { get; } = new(Create);
}
