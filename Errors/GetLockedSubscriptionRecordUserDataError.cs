using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetLockedSubscriptionRecordUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLockedSubscriptionRecordUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLockedSubscriptionRecordUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLockedSubscriptionRecordUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLockedSubscriptionRecordUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLockedSubscriptionRecordUserDataErrorResponse : IErrorResponse<GetLockedSubscriptionRecordUserDataError>
{
    public static GetLockedSubscriptionRecordUserDataErrorResponse Instance { get; } = new();

    private GetLockedSubscriptionRecordUserDataErrorResponse()
    {
    }

    public Task<GetLockedSubscriptionRecordUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLockedSubscriptionRecordUserDataError.Create(response, ct);
}
