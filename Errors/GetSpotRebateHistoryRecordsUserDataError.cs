using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetSpotRebateHistoryRecordsUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetSpotRebateHistoryRecordsUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetSpotRebateHistoryRecordsUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetSpotRebateHistoryRecordsUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetSpotRebateHistoryRecordsUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSpotRebateHistoryRecordsUserDataErrorResponse : IErrorResponse<GetSpotRebateHistoryRecordsUserDataError>
{
    public static GetSpotRebateHistoryRecordsUserDataErrorResponse Instance { get; } = new();

    private GetSpotRebateHistoryRecordsUserDataErrorResponse()
    {
    }

    public Task<GetSpotRebateHistoryRecordsUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetSpotRebateHistoryRecordsUserDataError.Create(response, ct);
}
