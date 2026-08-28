using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class AdjustCrossMarginMaxLeverageUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AdjustCrossMarginMaxLeverageUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AdjustCrossMarginMaxLeverageUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AdjustCrossMarginMaxLeverageUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AdjustCrossMarginMaxLeverageUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AdjustCrossMarginMaxLeverageUserDataErrorResponse : IErrorResponse<AdjustCrossMarginMaxLeverageUserDataError>
{
    public static AdjustCrossMarginMaxLeverageUserDataErrorResponse Instance { get; } = new();

    private AdjustCrossMarginMaxLeverageUserDataErrorResponse()
    {
    }

    public Task<AdjustCrossMarginMaxLeverageUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AdjustCrossMarginMaxLeverageUserDataError.Create(response, ct);
}
