using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataErrorResponse : IErrorResponse<QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError>
{
    public static QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataErrorResponse Instance { get; } = new();

    private QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataErrorResponse()
    {
    }

    public Task<QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError.Create(response, ct);
}
