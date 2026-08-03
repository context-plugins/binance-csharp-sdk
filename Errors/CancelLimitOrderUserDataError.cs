using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class CancelLimitOrderUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CancelLimitOrderUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CancelLimitOrderUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CancelLimitOrderUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CancelLimitOrderUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CancelLimitOrderUserDataErrorResponse : IErrorResponse<CancelLimitOrderUserDataError>
{
    public static CancelLimitOrderUserDataErrorResponse Instance { get; } = new();

    private CancelLimitOrderUserDataErrorResponse()
    {
    }

    public Task<CancelLimitOrderUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CancelLimitOrderUserDataError.Create(response, ct);
}
