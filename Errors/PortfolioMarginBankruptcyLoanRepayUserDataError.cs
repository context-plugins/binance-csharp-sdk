using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class PortfolioMarginBankruptcyLoanRepayUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private PortfolioMarginBankruptcyLoanRepayUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static PortfolioMarginBankruptcyLoanRepayUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static PortfolioMarginBankruptcyLoanRepayUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<PortfolioMarginBankruptcyLoanRepayUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PortfolioMarginBankruptcyLoanRepayUserDataErrorResponse : IErrorResponse<PortfolioMarginBankruptcyLoanRepayUserDataError>
{
    public static PortfolioMarginBankruptcyLoanRepayUserDataErrorResponse Instance { get; } = new();

    private PortfolioMarginBankruptcyLoanRepayUserDataErrorResponse()
    {
    }

    public Task<PortfolioMarginBankruptcyLoanRepayUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => PortfolioMarginBankruptcyLoanRepayUserDataError.Create(response, ct);
}
