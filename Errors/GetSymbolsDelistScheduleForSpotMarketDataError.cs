using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetSymbolsDelistScheduleForSpotMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetSymbolsDelistScheduleForSpotMarketDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetSymbolsDelistScheduleForSpotMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetSymbolsDelistScheduleForSpotMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetSymbolsDelistScheduleForSpotMarketDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSymbolsDelistScheduleForSpotMarketDataErrorResponse : IErrorResponse<GetSymbolsDelistScheduleForSpotMarketDataError>
{
    public static GetSymbolsDelistScheduleForSpotMarketDataErrorResponse Instance { get; } = new();

    private GetSymbolsDelistScheduleForSpotMarketDataErrorResponse()
    {
    }

    public Task<GetSymbolsDelistScheduleForSpotMarketDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetSymbolsDelistScheduleForSpotMarketDataError.Create(response, ct);
}
