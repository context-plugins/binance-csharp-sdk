using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class TimeWeightedAveragePriceTwapNewOrderTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private TimeWeightedAveragePriceTwapNewOrderTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static TimeWeightedAveragePriceTwapNewOrderTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static TimeWeightedAveragePriceTwapNewOrderTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<TimeWeightedAveragePriceTwapNewOrderTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class TimeWeightedAveragePriceTwapNewOrderTradeErrorResponse : IErrorResponse<TimeWeightedAveragePriceTwapNewOrderTradeError>
{
    public static TimeWeightedAveragePriceTwapNewOrderTradeErrorResponse Instance { get; } = new();

    private TimeWeightedAveragePriceTwapNewOrderTradeErrorResponse()
    {
    }

    public Task<TimeWeightedAveragePriceTwapNewOrderTradeError> Map(HttpResponseMessage response,
        CancellationToken ct) => TimeWeightedAveragePriceTwapNewOrderTradeError.Create(response, ct);
}
