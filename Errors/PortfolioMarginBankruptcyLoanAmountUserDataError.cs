using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class PortfolioMarginBankruptcyLoanAmountUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private PortfolioMarginBankruptcyLoanAmountUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static PortfolioMarginBankruptcyLoanAmountUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static PortfolioMarginBankruptcyLoanAmountUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<PortfolioMarginBankruptcyLoanAmountUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PortfolioMarginBankruptcyLoanAmountUserDataErrorResponse : IErrorResponse<PortfolioMarginBankruptcyLoanAmountUserDataError>
{
    public static PortfolioMarginBankruptcyLoanAmountUserDataErrorResponse Instance { get; } = new();

    private PortfolioMarginBankruptcyLoanAmountUserDataErrorResponse()
    {
    }

    public Task<PortfolioMarginBankruptcyLoanAmountUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => PortfolioMarginBankruptcyLoanAmountUserDataError.Create(response, ct);
}
