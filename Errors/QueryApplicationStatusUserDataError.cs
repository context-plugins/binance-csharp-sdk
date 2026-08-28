using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryApplicationStatusUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryApplicationStatusUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryApplicationStatusUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryApplicationStatusUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryApplicationStatusUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryApplicationStatusUserDataErrorResponse : IErrorResponse<QueryApplicationStatusUserDataError>
{
    public static QueryApplicationStatusUserDataErrorResponse Instance { get; } = new();

    private QueryApplicationStatusUserDataErrorResponse()
    {
    }

    public Task<QueryApplicationStatusUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryApplicationStatusUserDataError.Create(response, ct);
}
