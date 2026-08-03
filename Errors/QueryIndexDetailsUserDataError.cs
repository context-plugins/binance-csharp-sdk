using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryIndexDetailsUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryIndexDetailsUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryIndexDetailsUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryIndexDetailsUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryIndexDetailsUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryIndexDetailsUserDataErrorResponse : IErrorResponse<QueryIndexDetailsUserDataError>
{
    public static QueryIndexDetailsUserDataErrorResponse Instance { get; } = new();

    private QueryIndexDetailsUserDataErrorResponse()
    {
    }

    public Task<QueryIndexDetailsUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryIndexDetailsUserDataError.Create(response, ct);
}
