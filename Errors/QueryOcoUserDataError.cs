using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryOcoUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryOcoUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryOcoUserDataError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static QueryOcoUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryOcoUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryOcoUserDataErrorResponse : IErrorResponse<QueryOcoUserDataError>
{
    public static QueryOcoUserDataErrorResponse Instance { get; } = new();

    private QueryOcoUserDataErrorResponse()
    {
    }

    public Task<QueryOcoUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryOcoUserDataError.Create(response, ct);
}
