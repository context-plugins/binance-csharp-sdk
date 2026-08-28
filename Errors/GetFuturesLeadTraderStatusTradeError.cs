using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetFuturesLeadTraderStatusTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFuturesLeadTraderStatusTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFuturesLeadTraderStatusTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetFuturesLeadTraderStatusTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetFuturesLeadTraderStatusTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFuturesLeadTraderStatusTradeErrorResponse : IErrorResponse<GetFuturesLeadTraderStatusTradeError>
{
    public static GetFuturesLeadTraderStatusTradeErrorResponse Instance { get; } = new();

    private GetFuturesLeadTraderStatusTradeErrorResponse()
    {
    }

    public Task<GetFuturesLeadTraderStatusTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetFuturesLeadTraderStatusTradeError.Create(response, ct);
}
