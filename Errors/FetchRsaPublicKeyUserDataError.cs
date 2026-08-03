using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class FetchRsaPublicKeyUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FetchRsaPublicKeyUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FetchRsaPublicKeyUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static FetchRsaPublicKeyUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FetchRsaPublicKeyUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FetchRsaPublicKeyUserDataErrorResponse : IErrorResponse<FetchRsaPublicKeyUserDataError>
{
    public static FetchRsaPublicKeyUserDataErrorResponse Instance { get; } = new();

    private FetchRsaPublicKeyUserDataErrorResponse()
    {
    }

    public Task<FetchRsaPublicKeyUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        FetchRsaPublicKeyUserDataError.Create(response, ct);
}
