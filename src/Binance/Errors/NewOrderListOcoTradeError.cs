using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class NewOrderListOcoTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private NewOrderListOcoTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static NewOrderListOcoTradeError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static NewOrderListOcoTradeError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    private static Task<NewOrderListOcoTradeError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 => response.Json<Error>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<NewOrderListOcoTradeError> Response { get; } = new(Create);
}
