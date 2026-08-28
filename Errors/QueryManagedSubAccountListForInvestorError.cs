using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryManagedSubAccountListForInvestorError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryManagedSubAccountListForInvestorError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryManagedSubAccountListForInvestorError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryManagedSubAccountListForInvestorError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryManagedSubAccountListForInvestorError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryManagedSubAccountListForInvestorErrorResponse : IErrorResponse<QueryManagedSubAccountListForInvestorError>
{
    public static QueryManagedSubAccountListForInvestorErrorResponse Instance { get; } = new();

    private QueryManagedSubAccountListForInvestorErrorResponse()
    {
    }

    public Task<QueryManagedSubAccountListForInvestorError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryManagedSubAccountListForInvestorError.Create(response, ct);
}
