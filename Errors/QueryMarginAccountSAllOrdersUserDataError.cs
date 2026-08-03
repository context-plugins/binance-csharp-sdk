using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryMarginAccountSAllOrdersUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryMarginAccountSAllOrdersUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryMarginAccountSAllOrdersUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryMarginAccountSAllOrdersUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryMarginAccountSAllOrdersUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryMarginAccountSAllOrdersUserDataErrorResponse : IErrorResponse<QueryMarginAccountSAllOrdersUserDataError>
{
    public static QueryMarginAccountSAllOrdersUserDataErrorResponse Instance { get; } = new();

    private QueryMarginAccountSAllOrdersUserDataErrorResponse()
    {
    }

    public Task<QueryMarginAccountSAllOrdersUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryMarginAccountSAllOrdersUserDataError.Create(response, ct);
}
