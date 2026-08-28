using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryManagedSubAccountTransferLogForInvestorMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryManagedSubAccountTransferLogForInvestorMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryManagedSubAccountTransferLogForInvestorMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryManagedSubAccountTransferLogForInvestorMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryManagedSubAccountTransferLogForInvestorMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryManagedSubAccountTransferLogForInvestorMasterAccountErrorResponse : IErrorResponse<QueryManagedSubAccountTransferLogForInvestorMasterAccountError>
{
    public static QueryManagedSubAccountTransferLogForInvestorMasterAccountErrorResponse Instance { get; } = new();

    private QueryManagedSubAccountTransferLogForInvestorMasterAccountErrorResponse()
    {
    }

    public Task<QueryManagedSubAccountTransferLogForInvestorMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        QueryManagedSubAccountTransferLogForInvestorMasterAccountError.Create(response, ct);
}
