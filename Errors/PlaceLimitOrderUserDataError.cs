using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class PlaceLimitOrderUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private PlaceLimitOrderUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static PlaceLimitOrderUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static PlaceLimitOrderUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<PlaceLimitOrderUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PlaceLimitOrderUserDataErrorResponse : IErrorResponse<PlaceLimitOrderUserDataError>
{
    public static PlaceLimitOrderUserDataErrorResponse Instance { get; } = new();

    private PlaceLimitOrderUserDataErrorResponse()
    {
    }

    public Task<PlaceLimitOrderUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PlaceLimitOrderUserDataError.Create(response, ct);
}
