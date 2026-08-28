using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataErrorResponse : IErrorResponse<GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError>
{
    public static GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataErrorResponse Instance { get; } = new();

    private GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataErrorResponse()
    {
    }

    public Task<GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetTokensOrSymbolsDelistScheduleForCrossMarginAndIsolatedMarginMarketDataError.Create(response, ct);
}
