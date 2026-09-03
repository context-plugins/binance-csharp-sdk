using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetLockedProductPositionUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLockedProductPositionUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLockedProductPositionUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLockedProductPositionUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLockedProductPositionUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLockedProductPositionUserDataErrorResponse : IErrorResponse<GetLockedProductPositionUserDataError>
{
    public static GetLockedProductPositionUserDataErrorResponse Instance { get; } = new();

    private GetLockedProductPositionUserDataErrorResponse()
    {
    }

    public Task<GetLockedProductPositionUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLockedProductPositionUserDataError.Create(response, ct);
}
