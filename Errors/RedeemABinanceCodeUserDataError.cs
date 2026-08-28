using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class RedeemABinanceCodeUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RedeemABinanceCodeUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RedeemABinanceCodeUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RedeemABinanceCodeUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RedeemABinanceCodeUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RedeemABinanceCodeUserDataErrorResponse : IErrorResponse<RedeemABinanceCodeUserDataError>
{
    public static RedeemABinanceCodeUserDataErrorResponse Instance { get; } = new();

    private RedeemABinanceCodeUserDataErrorResponse()
    {
    }

    public Task<RedeemABinanceCodeUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RedeemABinanceCodeUserDataError.Create(response, ct);
}
