using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class SetLockedProductRedeemOptionUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SetLockedProductRedeemOptionUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SetLockedProductRedeemOptionUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SetLockedProductRedeemOptionUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SetLockedProductRedeemOptionUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetLockedProductRedeemOptionUserDataErrorResponse : IErrorResponse<SetLockedProductRedeemOptionUserDataError>
{
    public static SetLockedProductRedeemOptionUserDataErrorResponse Instance { get; } = new();

    private SetLockedProductRedeemOptionUserDataErrorResponse()
    {
    }

    public Task<SetLockedProductRedeemOptionUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetLockedProductRedeemOptionUserDataError.Create(response, ct);
}
