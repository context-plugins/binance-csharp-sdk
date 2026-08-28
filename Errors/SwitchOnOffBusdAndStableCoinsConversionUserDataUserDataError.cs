using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataErrorResponse : IErrorResponse<SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError>
{
    public static SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataErrorResponse Instance { get; } = new();

    private SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataErrorResponse()
    {
    }

    public Task<SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError.Create(response, ct);
}
