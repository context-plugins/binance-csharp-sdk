using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class RedeemLockedProductTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RedeemLockedProductTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RedeemLockedProductTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RedeemLockedProductTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RedeemLockedProductTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RedeemLockedProductTradeErrorResponse : IErrorResponse<RedeemLockedProductTradeError>
{
    public static RedeemLockedProductTradeErrorResponse Instance { get; } = new();

    private RedeemLockedProductTradeErrorResponse()
    {
    }

    public Task<RedeemLockedProductTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RedeemLockedProductTradeError.Create(response, ct);
}
