using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class RequestForMinerListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RequestForMinerListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RequestForMinerListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RequestForMinerListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RequestForMinerListUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RequestForMinerListUserDataErrorResponse : IErrorResponse<RequestForMinerListUserDataError>
{
    public static RequestForMinerListUserDataErrorResponse Instance { get; } = new();

    private RequestForMinerListUserDataErrorResponse()
    {
    }

    public Task<RequestForMinerListUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RequestForMinerListUserDataError.Create(response, ct);
}
