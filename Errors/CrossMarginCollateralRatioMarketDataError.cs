using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class CrossMarginCollateralRatioMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CrossMarginCollateralRatioMarketDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CrossMarginCollateralRatioMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CrossMarginCollateralRatioMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CrossMarginCollateralRatioMarketDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CrossMarginCollateralRatioMarketDataErrorResponse : IErrorResponse<CrossMarginCollateralRatioMarketDataError>
{
    public static CrossMarginCollateralRatioMarketDataErrorResponse Instance { get; } = new();

    private CrossMarginCollateralRatioMarketDataErrorResponse()
    {
    }

    public Task<CrossMarginCollateralRatioMarketDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CrossMarginCollateralRatioMarketDataError.Create(response, ct);
}
