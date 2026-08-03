using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class EnableFastWithdrawSwitchUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EnableFastWithdrawSwitchUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EnableFastWithdrawSwitchUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static EnableFastWithdrawSwitchUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EnableFastWithdrawSwitchUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EnableFastWithdrawSwitchUserDataErrorResponse : IErrorResponse<EnableFastWithdrawSwitchUserDataError>
{
    public static EnableFastWithdrawSwitchUserDataErrorResponse Instance { get; } = new();

    private EnableFastWithdrawSwitchUserDataErrorResponse()
    {
    }

    public Task<EnableFastWithdrawSwitchUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EnableFastWithdrawSwitchUserDataError.Create(response, ct);
}
