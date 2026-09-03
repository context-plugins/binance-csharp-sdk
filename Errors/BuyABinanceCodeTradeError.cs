using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class BuyABinanceCodeTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private BuyABinanceCodeTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static BuyABinanceCodeTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static BuyABinanceCodeTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<BuyABinanceCodeTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BuyABinanceCodeTradeErrorResponse : IErrorResponse<BuyABinanceCodeTradeError>
{
    public static BuyABinanceCodeTradeErrorResponse Instance { get; } = new();

    private BuyABinanceCodeTradeErrorResponse()
    {
    }

    public Task<BuyABinanceCodeTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        BuyABinanceCodeTradeError.Create(response, ct);
}
