using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetAllCrossMarginPairsMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAllCrossMarginPairsMarketDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAllCrossMarginPairsMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAllCrossMarginPairsMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAllCrossMarginPairsMarketDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAllCrossMarginPairsMarketDataErrorResponse : IErrorResponse<GetAllCrossMarginPairsMarketDataError>
{
    public static GetAllCrossMarginPairsMarketDataErrorResponse Instance { get; } = new();

    private GetAllCrossMarginPairsMarketDataErrorResponse()
    {
    }

    public Task<GetAllCrossMarginPairsMarketDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAllCrossMarginPairsMarketDataError.Create(response, ct);
}
