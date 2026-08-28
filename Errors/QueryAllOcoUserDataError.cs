using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryAllOcoUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryAllOcoUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryAllOcoUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryAllOcoUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryAllOcoUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryAllOcoUserDataErrorResponse : IErrorResponse<QueryAllOcoUserDataError>
{
    public static QueryAllOcoUserDataErrorResponse Instance { get; } = new();

    private QueryAllOcoUserDataErrorResponse()
    {
    }

    public Task<QueryAllOcoUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryAllOcoUserDataError.Create(response, ct);
}
