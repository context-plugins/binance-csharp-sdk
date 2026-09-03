using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryMarginAccountSOrderUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryMarginAccountSOrderUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryMarginAccountSOrderUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryMarginAccountSOrderUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryMarginAccountSOrderUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryMarginAccountSOrderUserDataErrorResponse : IErrorResponse<QueryMarginAccountSOrderUserDataError>
{
    public static QueryMarginAccountSOrderUserDataErrorResponse Instance { get; } = new();

    private QueryMarginAccountSOrderUserDataErrorResponse()
    {
    }

    public Task<QueryMarginAccountSOrderUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryMarginAccountSOrderUserDataError.Create(response, ct);
}
