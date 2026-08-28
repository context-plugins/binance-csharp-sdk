using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataErrorResponse : IErrorResponse<ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError>
{
    public static ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataErrorResponse Instance { get; } = new();

    private ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataErrorResponse()
    {
    }

    public Task<ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => ToggleBnbBurnOnSpotTradeAndMarginInterestUserDataError.Create(response, ct);
}
