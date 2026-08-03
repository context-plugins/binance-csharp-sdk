using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class RedemptionRecordUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RedemptionRecordUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RedemptionRecordUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RedemptionRecordUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RedemptionRecordUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RedemptionRecordUserDataErrorResponse : IErrorResponse<RedemptionRecordUserDataError>
{
    public static RedemptionRecordUserDataErrorResponse Instance { get; } = new();

    private RedemptionRecordUserDataErrorResponse()
    {
    }

    public Task<RedemptionRecordUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RedemptionRecordUserDataError.Create(response, ct);
}
