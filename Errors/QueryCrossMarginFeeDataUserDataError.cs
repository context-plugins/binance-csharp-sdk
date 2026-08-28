using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryCrossMarginFeeDataUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryCrossMarginFeeDataUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryCrossMarginFeeDataUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryCrossMarginFeeDataUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryCrossMarginFeeDataUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryCrossMarginFeeDataUserDataErrorResponse : IErrorResponse<QueryCrossMarginFeeDataUserDataError>
{
    public static QueryCrossMarginFeeDataUserDataErrorResponse Instance { get; } = new();

    private QueryCrossMarginFeeDataUserDataErrorResponse()
    {
    }

    public Task<QueryCrossMarginFeeDataUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryCrossMarginFeeDataUserDataError.Create(response, ct);
}
