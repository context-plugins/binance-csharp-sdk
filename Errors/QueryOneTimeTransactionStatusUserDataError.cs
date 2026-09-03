using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryOneTimeTransactionStatusUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryOneTimeTransactionStatusUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryOneTimeTransactionStatusUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryOneTimeTransactionStatusUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryOneTimeTransactionStatusUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryOneTimeTransactionStatusUserDataErrorResponse : IErrorResponse<QueryOneTimeTransactionStatusUserDataError>
{
    public static QueryOneTimeTransactionStatusUserDataErrorResponse Instance { get; } = new();

    private QueryOneTimeTransactionStatusUserDataErrorResponse()
    {
    }

    public Task<QueryOneTimeTransactionStatusUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryOneTimeTransactionStatusUserDataError.Create(response, ct);
}
