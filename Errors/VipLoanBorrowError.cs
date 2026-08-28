using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class VipLoanBorrowError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private VipLoanBorrowError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static VipLoanBorrowError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static VipLoanBorrowError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<VipLoanBorrowError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class VipLoanBorrowErrorResponse : IErrorResponse<VipLoanBorrowError>
{
    public static VipLoanBorrowErrorResponse Instance { get; } = new();

    private VipLoanBorrowErrorResponse()
    {
    }

    public Task<VipLoanBorrowError> Map(HttpResponseMessage response, CancellationToken ct) =>
        VipLoanBorrowError.Create(response, ct);
}
