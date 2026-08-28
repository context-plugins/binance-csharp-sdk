using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetCryptoLoansIncomeHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetCryptoLoansIncomeHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetCryptoLoansIncomeHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetCryptoLoansIncomeHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetCryptoLoansIncomeHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCryptoLoansIncomeHistoryUserDataErrorResponse : IErrorResponse<GetCryptoLoansIncomeHistoryUserDataError>
{
    public static GetCryptoLoansIncomeHistoryUserDataErrorResponse Instance { get; } = new();

    private GetCryptoLoansIncomeHistoryUserDataErrorResponse()
    {
    }

    public Task<GetCryptoLoansIncomeHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCryptoLoansIncomeHistoryUserDataError.Create(response, ct);
}
