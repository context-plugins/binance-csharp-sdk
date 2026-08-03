using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryIndexLinkedPlanPositionDetailsUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryIndexLinkedPlanPositionDetailsUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryIndexLinkedPlanPositionDetailsUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryIndexLinkedPlanPositionDetailsUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryIndexLinkedPlanPositionDetailsUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryIndexLinkedPlanPositionDetailsUserDataErrorResponse : IErrorResponse<QueryIndexLinkedPlanPositionDetailsUserDataError>
{
    public static QueryIndexLinkedPlanPositionDetailsUserDataErrorResponse Instance { get; } = new();

    private QueryIndexLinkedPlanPositionDetailsUserDataErrorResponse()
    {
    }

    public Task<QueryIndexLinkedPlanPositionDetailsUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => QueryIndexLinkedPlanPositionDetailsUserDataError.Create(response, ct);
}
