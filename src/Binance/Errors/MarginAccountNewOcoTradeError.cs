using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class MarginAccountNewOcoTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private MarginAccountNewOcoTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static MarginAccountNewOcoTradeError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static MarginAccountNewOcoTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    private static Task<MarginAccountNewOcoTradeError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 => response.Json<Error>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<MarginAccountNewOcoTradeError> Response { get; } = new(Create);
}
