using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class MarginAccountBorrowRepayMarginError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private MarginAccountBorrowRepayMarginError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static MarginAccountBorrowRepayMarginError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static MarginAccountBorrowRepayMarginError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<MarginAccountBorrowRepayMarginError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MarginAccountBorrowRepayMarginErrorResponse : IErrorResponse<MarginAccountBorrowRepayMarginError>
{
    public static MarginAccountBorrowRepayMarginErrorResponse Instance { get; } = new();

    private MarginAccountBorrowRepayMarginErrorResponse()
    {
    }

    public Task<MarginAccountBorrowRepayMarginError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MarginAccountBorrowRepayMarginError.Create(response, ct);
}
