using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class BlvtUserLimitInfoUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private BlvtUserLimitInfoUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static BlvtUserLimitInfoUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static BlvtUserLimitInfoUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<BlvtUserLimitInfoUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BlvtUserLimitInfoUserDataErrorResponse : IErrorResponse<BlvtUserLimitInfoUserDataError>
{
    public static BlvtUserLimitInfoUserDataErrorResponse Instance { get; } = new();

    private BlvtUserLimitInfoUserDataErrorResponse()
    {
    }

    public Task<BlvtUserLimitInfoUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        BlvtUserLimitInfoUserDataError.Create(response, ct);
}
