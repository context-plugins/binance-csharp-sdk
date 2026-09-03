using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class AcquiringCoinNameMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AcquiringCoinNameMarketDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AcquiringCoinNameMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AcquiringCoinNameMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AcquiringCoinNameMarketDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AcquiringCoinNameMarketDataErrorResponse : IErrorResponse<AcquiringCoinNameMarketDataError>
{
    public static AcquiringCoinNameMarketDataErrorResponse Instance { get; } = new();

    private AcquiringCoinNameMarketDataErrorResponse()
    {
    }

    public Task<AcquiringCoinNameMarketDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AcquiringCoinNameMarketDataError.Create(response, ct);
}
