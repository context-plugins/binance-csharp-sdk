using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetLockedSubscriptionPreviewUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLockedSubscriptionPreviewUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLockedSubscriptionPreviewUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLockedSubscriptionPreviewUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLockedSubscriptionPreviewUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLockedSubscriptionPreviewUserDataErrorResponse : IErrorResponse<GetLockedSubscriptionPreviewUserDataError>
{
    public static GetLockedSubscriptionPreviewUserDataErrorResponse Instance { get; } = new();

    private GetLockedSubscriptionPreviewUserDataErrorResponse()
    {
    }

    public Task<GetLockedSubscriptionPreviewUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLockedSubscriptionPreviewUserDataError.Create(response, ct);
}
