using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetForceLiquidationRecordUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetForceLiquidationRecordUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetForceLiquidationRecordUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetForceLiquidationRecordUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetForceLiquidationRecordUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetForceLiquidationRecordUserDataErrorResponse : IErrorResponse<GetForceLiquidationRecordUserDataError>
{
    public static GetForceLiquidationRecordUserDataErrorResponse Instance { get; } = new();

    private GetForceLiquidationRecordUserDataErrorResponse()
    {
    }

    public Task<GetForceLiquidationRecordUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetForceLiquidationRecordUserDataError.Create(response, ct);
}
