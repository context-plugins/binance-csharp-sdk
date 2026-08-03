using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class TimeWeightedAveragePriceTwapNewOrderError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private TimeWeightedAveragePriceTwapNewOrderError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static TimeWeightedAveragePriceTwapNewOrderError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static TimeWeightedAveragePriceTwapNewOrderError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<TimeWeightedAveragePriceTwapNewOrderError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class TimeWeightedAveragePriceTwapNewOrderErrorResponse : IErrorResponse<TimeWeightedAveragePriceTwapNewOrderError>
{
    public static TimeWeightedAveragePriceTwapNewOrderErrorResponse Instance { get; } = new();

    private TimeWeightedAveragePriceTwapNewOrderErrorResponse()
    {
    }

    public Task<TimeWeightedAveragePriceTwapNewOrderError> Map(HttpResponseMessage response, CancellationToken ct) =>
        TimeWeightedAveragePriceTwapNewOrderError.Create(response, ct);
}
