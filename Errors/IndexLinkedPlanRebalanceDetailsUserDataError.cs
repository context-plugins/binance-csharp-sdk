using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class IndexLinkedPlanRebalanceDetailsUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private IndexLinkedPlanRebalanceDetailsUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static IndexLinkedPlanRebalanceDetailsUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static IndexLinkedPlanRebalanceDetailsUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<IndexLinkedPlanRebalanceDetailsUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class IndexLinkedPlanRebalanceDetailsUserDataErrorResponse : IErrorResponse<IndexLinkedPlanRebalanceDetailsUserDataError>
{
    public static IndexLinkedPlanRebalanceDetailsUserDataErrorResponse Instance { get; } = new();

    private IndexLinkedPlanRebalanceDetailsUserDataErrorResponse()
    {
    }

    public Task<IndexLinkedPlanRebalanceDetailsUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => IndexLinkedPlanRebalanceDetailsUserDataError.Create(response, ct);
}
