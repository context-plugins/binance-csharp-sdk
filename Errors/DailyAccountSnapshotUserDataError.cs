using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class DailyAccountSnapshotUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DailyAccountSnapshotUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DailyAccountSnapshotUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DailyAccountSnapshotUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DailyAccountSnapshotUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DailyAccountSnapshotUserDataErrorResponse : IErrorResponse<DailyAccountSnapshotUserDataError>
{
    public static DailyAccountSnapshotUserDataErrorResponse Instance { get; } = new();

    private DailyAccountSnapshotUserDataErrorResponse()
    {
    }

    public Task<DailyAccountSnapshotUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DailyAccountSnapshotUserDataError.Create(response, ct);
}
