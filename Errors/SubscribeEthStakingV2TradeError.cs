using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class SubscribeEthStakingV2TradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubscribeEthStakingV2TradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubscribeEthStakingV2TradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubscribeEthStakingV2TradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubscribeEthStakingV2TradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubscribeEthStakingV2TradeErrorResponse : IErrorResponse<SubscribeEthStakingV2TradeError>
{
    public static SubscribeEthStakingV2TradeErrorResponse Instance { get; } = new();

    private SubscribeEthStakingV2TradeErrorResponse()
    {
    }

    public Task<SubscribeEthStakingV2TradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SubscribeEthStakingV2TradeError.Create(response, ct);
}
