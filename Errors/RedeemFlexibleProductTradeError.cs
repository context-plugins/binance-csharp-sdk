using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class RedeemFlexibleProductTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RedeemFlexibleProductTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RedeemFlexibleProductTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RedeemFlexibleProductTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RedeemFlexibleProductTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RedeemFlexibleProductTradeErrorResponse : IErrorResponse<RedeemFlexibleProductTradeError>
{
    public static RedeemFlexibleProductTradeErrorResponse Instance { get; } = new();

    private RedeemFlexibleProductTradeErrorResponse()
    {
    }

    public Task<RedeemFlexibleProductTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RedeemFlexibleProductTradeError.Create(response, ct);
}
