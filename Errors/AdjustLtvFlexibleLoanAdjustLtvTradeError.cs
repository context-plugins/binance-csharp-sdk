using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class AdjustLtvFlexibleLoanAdjustLtvTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AdjustLtvFlexibleLoanAdjustLtvTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AdjustLtvFlexibleLoanAdjustLtvTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AdjustLtvFlexibleLoanAdjustLtvTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AdjustLtvFlexibleLoanAdjustLtvTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AdjustLtvFlexibleLoanAdjustLtvTradeErrorResponse : IErrorResponse<AdjustLtvFlexibleLoanAdjustLtvTradeError>
{
    public static AdjustLtvFlexibleLoanAdjustLtvTradeErrorResponse Instance { get; } = new();

    private AdjustLtvFlexibleLoanAdjustLtvTradeErrorResponse()
    {
    }

    public Task<AdjustLtvFlexibleLoanAdjustLtvTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AdjustLtvFlexibleLoanAdjustLtvTradeError.Create(response, ct);
}
