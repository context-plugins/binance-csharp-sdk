using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class IndexLinkedPlanRedemptionHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private IndexLinkedPlanRedemptionHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static IndexLinkedPlanRedemptionHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static IndexLinkedPlanRedemptionHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<IndexLinkedPlanRedemptionHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class IndexLinkedPlanRedemptionHistoryUserDataErrorResponse : IErrorResponse<IndexLinkedPlanRedemptionHistoryUserDataError>
{
    public static IndexLinkedPlanRedemptionHistoryUserDataErrorResponse Instance { get; } = new();

    private IndexLinkedPlanRedemptionHistoryUserDataErrorResponse()
    {
    }

    public Task<IndexLinkedPlanRedemptionHistoryUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => IndexLinkedPlanRedemptionHistoryUserDataError.Create(response, ct);
}
