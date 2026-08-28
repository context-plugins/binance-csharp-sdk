using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryAllocationsUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryAllocationsUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryAllocationsUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryAllocationsUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryAllocationsUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryAllocationsUserDataErrorResponse : IErrorResponse<QueryAllocationsUserDataError>
{
    public static QueryAllocationsUserDataErrorResponse Instance { get; } = new();

    private QueryAllocationsUserDataErrorResponse()
    {
    }

    public Task<QueryAllocationsUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryAllocationsUserDataError.Create(response, ct);
}
