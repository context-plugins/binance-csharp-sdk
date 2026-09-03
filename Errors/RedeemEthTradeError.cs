using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class RedeemEthTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RedeemEthTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RedeemEthTradeError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static RedeemEthTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RedeemEthTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RedeemEthTradeErrorResponse : IErrorResponse<RedeemEthTradeError>
{
    public static RedeemEthTradeErrorResponse Instance { get; } = new();

    private RedeemEthTradeErrorResponse()
    {
    }

    public Task<RedeemEthTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RedeemEthTradeError.Create(response, ct);
}
