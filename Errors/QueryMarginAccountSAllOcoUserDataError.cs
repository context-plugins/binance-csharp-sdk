using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryMarginAccountSAllOcoUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryMarginAccountSAllOcoUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryMarginAccountSAllOcoUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryMarginAccountSAllOcoUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryMarginAccountSAllOcoUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryMarginAccountSAllOcoUserDataErrorResponse : IErrorResponse<QueryMarginAccountSAllOcoUserDataError>
{
    public static QueryMarginAccountSAllOcoUserDataErrorResponse Instance { get; } = new();

    private QueryMarginAccountSAllOcoUserDataErrorResponse()
    {
    }

    public Task<QueryMarginAccountSAllOcoUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryMarginAccountSAllOcoUserDataError.Create(response, ct);
}
