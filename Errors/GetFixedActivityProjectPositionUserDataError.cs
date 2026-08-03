using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetFixedActivityProjectPositionUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFixedActivityProjectPositionUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFixedActivityProjectPositionUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetFixedActivityProjectPositionUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetFixedActivityProjectPositionUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFixedActivityProjectPositionUserDataErrorResponse : IErrorResponse<GetFixedActivityProjectPositionUserDataError>
{
    public static GetFixedActivityProjectPositionUserDataErrorResponse Instance { get; } = new();

    private GetFixedActivityProjectPositionUserDataErrorResponse()
    {
    }

    public Task<GetFixedActivityProjectPositionUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetFixedActivityProjectPositionUserDataError.Create(response, ct);
}
