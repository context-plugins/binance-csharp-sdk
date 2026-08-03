using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class FetchTokenLimitUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FetchTokenLimitUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FetchTokenLimitUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static FetchTokenLimitUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FetchTokenLimitUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FetchTokenLimitUserDataErrorResponse : IErrorResponse<FetchTokenLimitUserDataError>
{
    public static FetchTokenLimitUserDataErrorResponse Instance { get; } = new();

    private FetchTokenLimitUserDataErrorResponse()
    {
    }

    public Task<FetchTokenLimitUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        FetchTokenLimitUserDataError.Create(response, ct);
}
