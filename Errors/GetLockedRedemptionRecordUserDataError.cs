using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetLockedRedemptionRecordUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLockedRedemptionRecordUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLockedRedemptionRecordUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLockedRedemptionRecordUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLockedRedemptionRecordUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLockedRedemptionRecordUserDataErrorResponse : IErrorResponse<GetLockedRedemptionRecordUserDataError>
{
    public static GetLockedRedemptionRecordUserDataErrorResponse Instance { get; } = new();

    private GetLockedRedemptionRecordUserDataErrorResponse()
    {
    }

    public Task<GetLockedRedemptionRecordUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLockedRedemptionRecordUserDataError.Create(response, ct);
}
