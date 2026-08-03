using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataErrorResponse : IErrorResponse<QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError>
{
    public static QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataErrorResponse Instance { get; } = new();

    private QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataErrorResponse()
    {
    }

    public Task<QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        QueryLiabilityCoinLeverageBracketInCrossMarginProModeMarketDataError.Create(response, ct);
}
