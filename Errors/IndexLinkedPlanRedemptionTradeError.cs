using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class IndexLinkedPlanRedemptionTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private IndexLinkedPlanRedemptionTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static IndexLinkedPlanRedemptionTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static IndexLinkedPlanRedemptionTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<IndexLinkedPlanRedemptionTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class IndexLinkedPlanRedemptionTradeErrorResponse : IErrorResponse<IndexLinkedPlanRedemptionTradeError>
{
    public static IndexLinkedPlanRedemptionTradeErrorResponse Instance { get; } = new();

    private IndexLinkedPlanRedemptionTradeErrorResponse()
    {
    }

    public Task<IndexLinkedPlanRedemptionTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        IndexLinkedPlanRedemptionTradeError.Create(response, ct);
}
