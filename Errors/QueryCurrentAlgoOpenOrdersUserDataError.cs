using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryCurrentAlgoOpenOrdersUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryCurrentAlgoOpenOrdersUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryCurrentAlgoOpenOrdersUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryCurrentAlgoOpenOrdersUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryCurrentAlgoOpenOrdersUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryCurrentAlgoOpenOrdersUserDataErrorResponse : IErrorResponse<QueryCurrentAlgoOpenOrdersUserDataError>
{
    public static QueryCurrentAlgoOpenOrdersUserDataErrorResponse Instance { get; } = new();

    private QueryCurrentAlgoOpenOrdersUserDataErrorResponse()
    {
    }

    public Task<QueryCurrentAlgoOpenOrdersUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryCurrentAlgoOpenOrdersUserDataError.Create(response, ct);
}
