using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class MarginManualLiquidationMarginError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private MarginManualLiquidationMarginError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static MarginManualLiquidationMarginError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static MarginManualLiquidationMarginError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<MarginManualLiquidationMarginError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MarginManualLiquidationMarginErrorResponse : IErrorResponse<MarginManualLiquidationMarginError>
{
    public static MarginManualLiquidationMarginErrorResponse Instance { get; } = new();

    private MarginManualLiquidationMarginErrorResponse()
    {
    }

    public Task<MarginManualLiquidationMarginError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MarginManualLiquidationMarginError.Create(response, ct);
}
