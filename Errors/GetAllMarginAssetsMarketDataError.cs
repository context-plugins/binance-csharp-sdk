using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetAllMarginAssetsMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAllMarginAssetsMarketDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAllMarginAssetsMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAllMarginAssetsMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAllMarginAssetsMarketDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAllMarginAssetsMarketDataErrorResponse : IErrorResponse<GetAllMarginAssetsMarketDataError>
{
    public static GetAllMarginAssetsMarketDataErrorResponse Instance { get; } = new();

    private GetAllMarginAssetsMarketDataErrorResponse()
    {
    }

    public Task<GetAllMarginAssetsMarketDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAllMarginAssetsMarketDataError.Create(response, ct);
}
