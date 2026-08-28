using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetFlexibleSubscriptionPreviewUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFlexibleSubscriptionPreviewUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFlexibleSubscriptionPreviewUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetFlexibleSubscriptionPreviewUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetFlexibleSubscriptionPreviewUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFlexibleSubscriptionPreviewUserDataErrorResponse : IErrorResponse<GetFlexibleSubscriptionPreviewUserDataError>
{
    public static GetFlexibleSubscriptionPreviewUserDataErrorResponse Instance { get; } = new();

    private GetFlexibleSubscriptionPreviewUserDataErrorResponse()
    {
    }

    public Task<GetFlexibleSubscriptionPreviewUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetFlexibleSubscriptionPreviewUserDataError.Create(response, ct);
}
