using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class PortfolioMarginCollateralRateMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private PortfolioMarginCollateralRateMarketDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static PortfolioMarginCollateralRateMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static PortfolioMarginCollateralRateMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<PortfolioMarginCollateralRateMarketDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PortfolioMarginCollateralRateMarketDataErrorResponse : IErrorResponse<PortfolioMarginCollateralRateMarketDataError>
{
    public static PortfolioMarginCollateralRateMarketDataErrorResponse Instance { get; } = new();

    private PortfolioMarginCollateralRateMarketDataErrorResponse()
    {
    }

    public Task<PortfolioMarginCollateralRateMarketDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => PortfolioMarginCollateralRateMarketDataError.Create(response, ct);
}
