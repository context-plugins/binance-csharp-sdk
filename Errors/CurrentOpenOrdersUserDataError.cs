using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class CurrentOpenOrdersUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CurrentOpenOrdersUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CurrentOpenOrdersUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CurrentOpenOrdersUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CurrentOpenOrdersUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CurrentOpenOrdersUserDataErrorResponse : IErrorResponse<CurrentOpenOrdersUserDataError>
{
    public static CurrentOpenOrdersUserDataErrorResponse Instance { get; } = new();

    private CurrentOpenOrdersUserDataErrorResponse()
    {
    }

    public Task<CurrentOpenOrdersUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CurrentOpenOrdersUserDataError.Create(response, ct);
}
