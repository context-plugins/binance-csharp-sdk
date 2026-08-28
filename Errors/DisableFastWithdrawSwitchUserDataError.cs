using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class DisableFastWithdrawSwitchUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DisableFastWithdrawSwitchUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DisableFastWithdrawSwitchUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DisableFastWithdrawSwitchUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DisableFastWithdrawSwitchUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DisableFastWithdrawSwitchUserDataErrorResponse : IErrorResponse<DisableFastWithdrawSwitchUserDataError>
{
    public static DisableFastWithdrawSwitchUserDataErrorResponse Instance { get; } = new();

    private DisableFastWithdrawSwitchUserDataErrorResponse()
    {
    }

    public Task<DisableFastWithdrawSwitchUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DisableFastWithdrawSwitchUserDataError.Create(response, ct);
}
